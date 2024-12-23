using System.Reflection;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Interfaces;
using Microsoft.OpenApi.Models;
using Persistence.DB;
using Repository.Repositories;

namespace AsdWebApi.Configuration;

public static class ExtensionService
{
    public static void ConfigureDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AsdDbContext>(options =>
       {
           options.UseSqlServer(configuration.GetConnectionString("ASDDB"), option =>
           {
               option.MigrationsAssembly(Assembly.GetAssembly(typeof(AsdDbContext)).GetName().Name);
           });
       });
    }

    public static void ConfigureDependency(this IHostBuilder host)
    {
        host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

        host.ConfigureContainer<ContainerBuilder>(containerBuilder => containerBuilder.RegisterModule(new RepoServiceModule()));
    }

    public static void ConfigureAuthentication(this IServiceCollection services)
    {
        services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
             .AddCookie(option =>
             {
                 option.Cookie.SameSite = SameSiteMode.Lax;
                 option.Cookie.Name = ".ASD.Auth";
                 option.Cookie.SecurePolicy = CookieSecurePolicy.Always;
                 option.Cookie.HttpOnly = false;
                 option.ExpireTimeSpan = TimeSpan.FromDays(1);
                 option.Cookie.MaxAge = option.ExpireTimeSpan;
                 option.SlidingExpiration = false;
                 option.LoginPath = "/Hesap/Giris";
                 option.LogoutPath = "/Hesap/Cikis";
                 option.AccessDeniedPath = "/Hata/404";
                 option.ReturnUrlParameter = "ReturnUrl";
             });
    }
    public static void ConfigureSwaggerSetting(this IServiceCollection services)
    {
        services.AddSwaggerGen(s =>
        {
            s.SwaggerDoc("v1", new OpenApiInfo
            {
                Version = "1.0.1",
                Description = "<h1>ASD SOFT WEB API</h1>\r\n<p>proDuck ERP API, bir ASD Laminat A.Ş ürünüdür...</p>",
                Extensions = new Dictionary<string, IOpenApiExtension>
             {
                    { "ASD SOFT", new OpenApiObject
                      {
                       { "altText", new OpenApiString("proDuck Logo") }
                      }
                  }
              }
            });
            s.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Name = "Authorization",
                Type = SecuritySchemeType.Http,
                Scheme = "Bearer",
                BearerFormat = "JWT",
                In = ParameterLocation.Header,
                Description = "JWT Authorization header using the Bearer scheme."
            });
            s.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] {}
                    }
                });
        });
    }

}

