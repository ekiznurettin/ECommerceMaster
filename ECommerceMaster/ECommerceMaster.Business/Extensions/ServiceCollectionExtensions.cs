using ECommerceMaster.Business.Abstract;
using ECommerceMaster.Business.Concrete;
using ECommerceMaster.Core.Utilities.Security.Encyption;
using ECommerceMaster.Core.Utilities.Security.Jwt;
using ECommerceMaster.DataAccess.Abstract;
using ECommerceMaster.DataAccess.Concrete;
using ECommerceMaster.DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;

namespace ECommerceMaster.Businnes.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection, string connectionString, TokenOptions tokenOptions)
        {
            serviceCollection.AddDbContext<ShopContext>(options => options.UseSqlServer(connectionString).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));

            serviceCollection.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidIssuer = tokenOptions.Issuer,
                    ValidAudience = tokenOptions.Audience,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey)
                };
            });

            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddScoped<ICategoryService, CategoryManager>();
            serviceCollection.AddScoped<IProductService, ProductManager>();
            serviceCollection.AddScoped<IAuthService, AuthManager>();
            serviceCollection.AddScoped<IUserService, UserManager>();
            serviceCollection.AddScoped<ITokenHelper, JwtHelper>();
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            return serviceCollection;
        }
    }
}
