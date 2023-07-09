var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
//app.UseWelcomePage();

//Random random = new Random();

// Console Logger
//app.Use(async(context, next) => {
//    Console.WriteLine($"Loggin address {context.Request.Path}");
//    await next.Invoke();
//        }); 

//app.UseWhen(
//    context => context.Request.Path == "/random",
//    appBuilder =>
//    {
//        appBuilder.Use(async(context, next) =>
//                {
//                   await next(); 
//                });
//        appBuilder.Run(async context => 
//                {
//                   int random_int = random.Next(0,100);
//                   await context.Response.WriteAsync($"Random is {random_int}");
//                });
//    }
//        );

//async Task HandleRequest(HttpContext context)
//{
//    var response = context.Response;
//    response.Headers.ContentLanguage = "ru-RU";
//    response.Headers.ContentType = "text/html; charset=utf-8";
//    
//    var stringBuilder = new System.Text.StringBuilder("<table>");
//    foreach (var header in context.Request.Query)
//    {
//        stringBuilder.Append($"<tr><td>{header.Key}</td><td>{header.Value}</td></tr>");
//    }
//    stringBuilder.Append($"</table>");
//    stringBuilder.Append($"{context.Request.Path}");
//    await context.Response.WriteAsync(stringBuilder.ToString());
//}

//app.Run(HandleRequest);


RouteManager.Add("/", RoutesControllers.IndexRoute);

app.UseMiddleware<ErrorController>();
app.UseMiddleware<RoutingController>();

app.Run();
