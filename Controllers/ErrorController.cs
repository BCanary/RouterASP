public class ErrorController
{
    private readonly RequestDelegate next;
    public ErrorController(RequestDelegate next)
    {
        this.next = next;
    }
    public async Task InvokeAsync(HttpContext context)
    {
        await next.Invoke(context);
        try
        {
            int status_code = context.Response.StatusCode;
            if (status_code == 404)
            {
                await context.Response.WriteAsync("404 NOT FOUND");
            }
        }
        catch
        {
            
        }
    }
}
