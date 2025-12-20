namespace GameStore.Endpoints;

public static class UtilitiesEndpoints
{
    public static WebApplication MapUtilitiesEndpoints(this WebApplication app)
    {
        app.MapGet("/ping", () => "Pong!");
        
        return app;
    }
}
