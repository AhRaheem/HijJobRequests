using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace HijJobRequests.Filters;

public class ApiResponseFilter : IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context)
    {
        // No action required before execution
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        if (context.Result is ObjectResult objectResult)
        {
            var apiResponse = new ApiResponse<object>(objectResult.Value, "Operation successful.");
            context.Result = new ObjectResult(apiResponse)
            {
                StatusCode = objectResult.StatusCode
            };
        }
        else if (context.Result is StatusCodeResult statusCodeResult)
        {
            var apiResponse = new ApiResponse<object>("No content returned.");
            context.Result = new ObjectResult(apiResponse)
            {
                StatusCode = statusCodeResult.StatusCode
            };
        }
    }

}
