public class Route
{
    public readonly string path;
    public delegate Task RouteMethod(HttpContext context);
    private RouteMethod routeMethod;

    public Route(string path, RouteMethod Method)
    {
        this.path = path;
        this.routeMethod += Method;
    }

    public async Task CallMethod(HttpContext context)
    {
        await routeMethod(context);
    }
}

// TODO: Переписать Route на Map
public static class RouteManager
{
    private static List<Route> routes_list = new List<Route>();

    public static void Add(string path, Route.RouteMethod Method)
    {
        RouteManager.routes_list.Add(new Route(path, Method));
    }

    public static List<Route> GetRoutes()
    {
        return RouteManager.routes_list;
    }
}
