using Application.BusinessRules;
using Application.Services.Abstract;
using Application.Services.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application.DependencyResolvers
{
    public static class ServiceCollectionApplicationExtention
    {
        public static IServiceCollection AddApplicationServices(
            this IServiceCollection services,
            IConfiguration configuration
        )
        {
            services.AddScoped<IVehicleService, VehicleService>();

            services
                .AddScoped<ICarService, CarService>()
                .AddScoped<CarBusinessRules>();

            services
                .AddScoped<IBusService, BusService>()
                .AddScoped<BusBusinessRules>();

            services
                .AddScoped<IBoatService, BoatService>()
                .AddScoped<BoatBusinessRules>();


            services.AddAutoMapper(Assembly.GetExecutingAssembly()); 

            

            return services;
        }
    }
}
