using System.Collections;
using CoreLayer.ConfigurationModels;
using CoreLayer.IRepositories.IBaseRepositories;
using CoreLayer.IServices;
using CoreLayer.IServices.IBaseServices;
using CoreLayer.Models;
using DataLayer.Repositories.BaseRepositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServiceLayer.Mapping;
using ServiceLayer.Services;
using ServiceLayer.Services.BaseServices;

namespace ServiceLayer
{
    public static class ServiceRegistration
    {
        public static void AddServiceLayerRegistration(this IServiceCollection services, IConfiguration configuration)
        {
            // auto mapper registered
            services.AddAutoMapper(typeof(Mapper));


            // configuration
            services.Configure<TokenConfigurationModel>(configuration.GetSection("Token"));


            //service registered
            //services.AddScoped(typeof(IBaseService<,,>), typeof(BaseService<,,>));
            services.AddScoped(typeof(IBaseService<,,>), typeof(BaseService<,,>));
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<ITokenService, TokenService>();

            services.AddScoped<IDietService, DietService>();
            services.AddScoped<IPilatesService, PilatesService>();
            services.AddScoped<IPackageService, PackageService>();

        }
    }
}