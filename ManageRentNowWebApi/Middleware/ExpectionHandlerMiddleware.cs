using System.Net;

namespace ManageRentNow.Api.Middleware
{
    public class ExpectionHandlerMiddleware
    {
        private readonly ILogger<ExpectionHandlerMiddleware> logger;
        private readonly RequestDelegate next;

        public ExpectionHandlerMiddleware(ILogger<ExpectionHandlerMiddleware> logger,
            RequestDelegate next)
        {
            this.logger = logger;
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await next(httpContext);
            }
            catch (Exception ex)
            {
                var errorId = Guid.NewGuid().ToString();
                logger.LogError(ex, $"{errorId} : {ex.Message}");

                httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                httpContext.Response.ContentType = "application/json";

                var error = new
                {
                    errorId,
                    message = ex.Message ?? "An error occurred in the application: unknown error"
                };
                await httpContext.Response.WriteAsJsonAsync(error);
            }
        }
    }

}
