using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class LogDoisMiddleware
    {
        private readonly RequestDelegate _next;

        public LogDoisMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {

            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class LogDoisMiddlewareExtensions
    {
        public static IApplicationBuilder UseLogDoisMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LogDoisMiddleware>();
        }
    }
}
