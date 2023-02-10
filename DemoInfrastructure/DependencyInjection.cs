using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Uzum.Aplication.Abstractions;
using Uzum.Infrastructure.Persistence;
using Uzum.Infrastructure.Services;

namespace Uzum.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext, ApplicationDbContext>(options =>
                    options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
            services.AddSingleton<IHashService, HashService>();
            services.AddScoped<ITokenService, JWTService>();
            return services;
        }
    }
}
