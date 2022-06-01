using BProduct.Application.Interfaces.Repositories;
using BProduct.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BProduct.Infrastructure.Persistence.Extensions;

public static class Registration
{
    public static IServiceCollection AddInfrastructureRegistration(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<BProductContext>(
            conf =>
            {
                var connStr = configuration["BProductDbConnectionString"].ToString();
                conf.UseSqlServer(connStr, opt =>
                {
                    opt.EnableRetryOnFailure();
                });
            });

        //Seed startup datas
        var seedData = new SeedData();
        seedData.SeedAsync(configuration).GetAwaiter().GetResult();

        //services.AddScoped<IProductRepository, ProductRepository>();
        //services.AddScoped<ICategoryRepository, CategoryRepository>();

        return services;
    }
}
