public class RoutingController
{
    private readonly RequestDelegate next;
    //private RouteManager routeManager; 

    public RoutingController(RequestDelegate next)
    {
        this.next = next;
        //this.routeManager = new RouteManager();
    }

    public async Task InvokeAsync(HttpContext context)
    {
        string path = context.Request.Path;
        foreach (var i in RouteManager.GetRoutes())
        {
            if (path == i.path)
            {
                await i.CallMethod(context);
                return;
            }
        }
        context.Response.StatusCode = 404;
    }
}
