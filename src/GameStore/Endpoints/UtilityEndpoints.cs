namespace GameStore.Endpoints;

public static class UtilityEndpoints
{
    public static WebApplication MapUtilityEndpoints(this WebApplication app)
    {
        app.MapGet("/ping", () => "Pong!");
        
        return app;
    }
}
