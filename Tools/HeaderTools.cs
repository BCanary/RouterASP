public static class HeaderTools
{
    public static void SetHeaders(HeaderType type, HttpContext context)
    {
        var headers = context.Response.Headers; 
        headers.ContentLanguage = "ru-RU";
        if (type == HeaderType.HTML) 
        {
           headers.ContentType = "text/html; charset=UTF-8"; 
        }
    }
}
