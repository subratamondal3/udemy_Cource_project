namespace MyProject
{
    public class MyCustomMiddlewareClass : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Hello from MyCustomMiddlewareClass --Starts");
            await next(context);
            await context.Response.WriteAsync("Hello from MyCustomMiddlewareClass --Ends");
        }
    }
}
