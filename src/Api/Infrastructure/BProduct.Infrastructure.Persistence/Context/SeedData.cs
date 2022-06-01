using Bogus;
using BProduct.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BProduct.Infrastructure.Persistence.Context;

public class SeedData
{
    private static List<Product> GetProducts()
    {
        var result = new Faker<Product>("tr")
            .RuleFor(i => i.Id, i => Guid.NewGuid())
            .RuleFor(i => i.CreateDate, i => i.Date.Between(DateTime.Now.AddDays(-100), DateTime.Now))
            .RuleFor(i => i.ProductCatalogId, i => i.PickRandom(1, 99))
            .RuleFor(i => i.Price, i => i.Commerce.Price().First())
            .RuleFor(i => i.Name, i => i.Commerce.ProductName())
            .Generate(100);

        return result;
    }

    public async Task SeedAsync(IConfiguration configuration)
    {
        var dbContextBuilder = new DbContextOptionsBuilder();
        dbContextBuilder.UseSqlServer(configuration["BProductDbConnectionString"]);

        var context = new BProductContext(dbContextBuilder.Options);

        if (context.Products.Any())
        {
            await Task.CompletedTask;
            return;
        }

        //Seed product datas
        var products = GetProducts();
        var productIds = products.Select(i => i.Id);

        await context.AddRangeAsync(products);

        //Seed Category Datas
        var guids = Enumerable.Range(0, 100).Select(i => Guid.NewGuid()).ToList();

        int counter = 0;

        var categories = new Faker<Category>("tr")
          .RuleFor(i => i.Id, i => guids[counter++])
          .RuleFor(i => i.CreateDate, i => i.Date.Between(DateTime.Now.AddDays(-100), DateTime.Now))
          .RuleFor(i => i.Name, i => i.Commerce.Categories(1).FirstOrDefault())
          .RuleFor(i => i.Products, i => products.Take(3))
          .Generate(10);

        await context.Categories.AddRangeAsync(categories);

        await context.SaveChangesAsync();
    }
}
