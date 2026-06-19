using Microsoft.EntityFrameworkCore;
using Patinhas.Infrastructure.Context;

public static class MigrationConfiguration
{
    public static async Task Migrate(this WebApplication app)
    {
        using (var scope = app.Services.CreateScope())
        {
            var db = scope.ServiceProvider.GetRequiredService<PatinhasContext>();
            db.Database.Migrate();

            var seeder = scope.ServiceProvider
                .GetRequiredService<SeedService>();

            await seeder.SeedData();
        }
    }
}