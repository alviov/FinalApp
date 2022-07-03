using FinalApp.DB;
using Microsoft.EntityFrameworkCore;

namespace FinalApp;

public static class StartupExtension
{
    /// <summary>
    /// Регистрирует appDbContext.
    /// </summary>
    /// <param name="services">Контейнер.</param>
    public static void ConfigureDbConnection(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDBContext>(options =>
            options.UseNpgsql(@"Host=localhost;Port=5432;Database=Irradiation;Username=postgres;Password=admin"));
    }
}

