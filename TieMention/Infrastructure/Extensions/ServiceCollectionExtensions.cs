using TieMention.Infrastructure.Data;
using TieMention.Infrastructure.Data.Repositories;
using TieMention.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TieMention.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services, 
        IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseNpgsql( // Usa o provedor Npgsql
                configuration.GetConnectionString("PostgresConnection"),
                npgsqlOptions => npgsqlOptions.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)
            );

            // Opcional: Logging para debug
            options.LogTo(Console.WriteLine, LogLevel.Information);
        });

        services.AddScoped<IMentionRepository, MentionRepository>();
        return services;
    }
}