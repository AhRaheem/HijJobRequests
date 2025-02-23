using System.Text;
using HijJobRequests.Filters;
using HijJobRequests.Middlewares;
using HijJobRequests.Models;
using HijJobRequests.Services.AppUser;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add database context with SQL Server connection
builder.Services.AddDbContext<DbIthraaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection_101")));

// Add controllers and apply global filters
builder.Services.AddControllers(options => { options.Filters.Add<ApiResponseFilter>(); });
builder.Services.AddHttpContextAccessor();

// Register services for the current user
builder.Services.AddScoped<ICurrentUserService, CurrentUserService>();

// Add Swagger for API documentation
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add authentication using JWT
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    var jwtSettings = builder.Configuration.GetSection("JwtSettings");
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = jwtSettings["Issuer"],
        ValidAudience = jwtSettings["Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["Secret"]))
    };
});

// Add CORS policy to allow all origins, methods, and headers
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

var app = builder.Build();

// Configure the app for development environment
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Enable CORS
app.UseCors("AllowAll");

// Serve static files (e.g., React app)
app.UseStaticFiles();

// Redirect all non-API, non-file requests to index.html for React app routing
//app.Use(async (context, next) =>
//{
//    // Check if the request is for an API or if it's a request for a file (like .css, .js, etc.)
//    if (!context.Request.Path.Value.StartsWith("/api") &&
//        !System.IO.Path.HasExtension(context.Request.Path.Value))
//    {
//        // Redirect to index.html for all other requests (React frontend)
//        context.Response.Redirect("/index.html");
//        return;
//    }
//    await next();
//});

// Enable HTTPS redirection
//app.UseHttpsRedirection();

// Set up authentication and authorization middleware
app.UseAuthentication();
app.UseAuthorization();

// Map controllers for API endpoints
app.MapControllers();
app.MapFallbackToFile("index.html");
// Apply custom error handling middleware (optional)
app.UseMiddleware<ErrorHandlerMiddleware>();

// Start the app
app.Run();
