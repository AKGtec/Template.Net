using Microsoft.EntityFrameworkCore;
using ProjectTemplate.Contracts;
using ProjectTemplate.Contracts.Repository;
using ProjectTemplate.LoggerService;
using ProjectTemplate.Models.DataSource;
using ProjectTemplate.Repository.Repository;
using ProjectTemplate.Service;
using ProjectTemplate.Service.Contracts;

namespace ProjectTemplate.API.ExtensionMethods;

public static class ServiceExtensions
{
    public static void ConfigureCors(this IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder =>
            builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
        });
    }

    public static void ConfigureIISIntegration(this IServiceCollection services)
    {
        services.Configure<IISOptions>(options =>
        {
        });
    }

    public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ProjectTemplateContext>(options => 
            options.UseSqlServer(configuration.GetConnectionString("sqlConnection")));
        services.AddScoped<ProjectTemplateContext>();
    }

    public static void ConfigureLoggerService(this IServiceCollection services)
    {
        services.AddSingleton<ILoggerManager, LoggerManager>();
    }

    public static void ConfigureRepositoryManager(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IRepositoryManager, RepositoryManager>();
        services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
        
        // Add your specific repository services here
        // Example: services.AddScoped<IUserService, UserService>();
    }

    public static void ConfigureServiceManager(this IServiceCollection services)
    {
        services.AddScoped<IServiceManager, ServiceManager>();
        
        // Add your specific services here
        // Example: services.AddScoped<IUserService, UserService>();
    }
}
