//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//app.Run();
using Microsoft.Extensions.FileProviders;
using MyProject;
var builder = WebApplication.CreateBuilder(new WebApplicationOptions()
{
    WebRootPath="myroot"
});
//builder.Services.AddTransient<MyCustomMiddlewareClass>();
builder.Services.AddControllers();
var app = builder.Build();

//app.Use(async (HttpContext context, RequestDelegate next) =>
//{
//    await context.Response.WriteAsync("Hello ");
//    await next(context);
//    await context.Response.WriteAsync("World");
//});

//app.UseMiddleware<MyCustomMiddlewareClass>();
//app.UseHelloCustomMiddleware();

//app.Run(async (HttpContext context) =>
//{
//    await context.Response.WriteAsync("Hello again");
//});
app.UseStaticFiles();
app.UseStaticFiles(new StaticFileOptions()
{
    FileProvider = new PhysicalFileProvider(Path.Combine(builder.Environment.ContentRootPath,"mywebroot"))
});
//app.UseRouting();
//app.UseEndpoints(endpoints =>
//{
//    endpoints.Map("map1", async (context) =>
//    {
//        await context.Response.WriteAsync("Hello from map1");
//    });
//});
//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllers();
//});
app.MapControllers();
app.Run();