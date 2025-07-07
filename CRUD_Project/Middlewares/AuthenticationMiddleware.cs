// AuthenticationMiddleware.cs

using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Security.Claims;
using System.Threading.Tasks;

namespace UserManagementAPI.Middlewares
{
    public class AuthenticationMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<AuthenticationMiddleware> _logger;

        public AuthenticationMiddleware(RequestDelegate next, ILogger<AuthenticationMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault();
            if (string.IsNullOrEmpty(token))
            {
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                await context.Response.WriteAsync("{\"error\": \"Unauthorized\"}");
                return;
            }

            // Validate token logic here
            // For demonstration purposes, we'll assume the token is valid
            var claims = new[] { new Claim(ClaimTypes.Name, "John Doe") };
            var identity = new ClaimsIdentity(claims, "Token");
            context.User = new ClaimsPrincipal(identity);

            await _next(context);
        }
    }
}