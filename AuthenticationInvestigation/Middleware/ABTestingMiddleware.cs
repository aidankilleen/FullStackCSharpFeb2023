namespace AuthenticationInvestigation.Middleware
{
    public class ABTestingMiddleware
    {
        private RequestDelegate _next;
        private ILogger<ABTestingMiddleware> _logger;

        public ABTestingMiddleware(RequestDelegate next, ILogger<ABTestingMiddleware> logger) {
            _next = next;
            _logger = logger;
        }

        public Task Invoke(HttpContext httpContext)
        {
            _logger.LogInformation("*******AB Testing Middleware Activated");
            _logger.LogInformation(httpContext.Request.Path);


            // TODO actually implement the middleware
            if (httpContext.Request.Path.StartsWithSegments("/Marketing/Index"))
            {
                Random r = new Random();

                if (r.Next(100) > 50)
                {
                    httpContext.Response.Redirect("/Marketing/PromoA");
                } else
                {
                    httpContext.Response.Redirect("/Marketing/PromoB");
                }
            }

            return _next(httpContext);
        }
    }

    public static class ABTestingMiddlewareExtensions
    {
        public static IApplicationBuilder UseABTestingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ABTestingMiddleware>();
        }
    }

}
