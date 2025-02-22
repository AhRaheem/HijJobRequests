using System;
using System.Net;
using System.Text.Json;

namespace HijJobRequests.Middlewares;

public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var response = context.Response;
            response.ContentType = "application/json";

            var statusCode = HttpStatusCode.InternalServerError;
            var result = JsonSerializer.Serialize(new ApiResponse<string>("An unexpected error occurred.", new List<string> { exception.Message }));

            response.StatusCode = (int)statusCode;

            return response.WriteAsync(result);
        }
    }
