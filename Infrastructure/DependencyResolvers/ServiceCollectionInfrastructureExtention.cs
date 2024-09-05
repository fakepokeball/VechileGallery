using Infrastructure.Data;
using Infrastructure.Repositories.Abstract;
using Infrastructure.Repositories.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.DependencyResolvers
{
    public static class ServiceCollectionInfrastructureExtention
    {
        public static IServiceCollection AddInfrastructureServices(
            this IServiceCollection services,
            IConfiguration configuration
        )
        {
            services
                .AddScoped<ICarRepository, CarRepository>();

            services
                .AddScoped<IBusRepository, BusRepository>();

            services
                .AddScoped<IBoatRepository, BoatRepository>();



            services.AddDbContext<VehicleGalleryDbContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
            );

            return services;
        }
    }
}
