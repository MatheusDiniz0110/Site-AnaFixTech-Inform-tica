public class JwtMiddleware
{
    private readonly RequestDelegate _next;


    public JwtMiddleware(RequestDelegate next)
    {
        _next = next;
    }


    public async Task Invoke(HttpContext context)
    {
        var token =
            context.Session.GetString("JWT");


        if (token != null)
        {
            context.Request.Headers.Authorization =
                "Bearer " + token;
        }


        await _next(context);
    }
}