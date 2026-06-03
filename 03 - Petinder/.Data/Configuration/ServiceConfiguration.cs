public static class ServiceConfiguration
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddHttpClient<SeedService>();
        // services.AddTransient<I_Service, _Service>();
    }
}