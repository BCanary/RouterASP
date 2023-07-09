public static class RoutesControllers
{
    private static readonly string ViewsPath = ProgramVariables.ViewsPath; 

    public static async Task IndexRoute(HttpContext context)
    {
        HeaderTools.SetHeaders(HeaderType.HTML, context); 
        await context.Response.SendFileAsync(@$"{ViewsPath}\index.html");
    }
}
