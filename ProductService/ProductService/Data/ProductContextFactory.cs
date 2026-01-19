using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
//lo que hacemos con esta clase es permitir que las migraciones puedan ejecutarse desde la consola de Package Manager Console o desde la CLI de dotnet
//ya que estas herramientas necesitan crear una instancia del DbContext en tiempo de diseño
namespace ProductService.Data
{
    public class ProductContextFactory : IDesignTimeDbContextFactory<ProductContext>
    {
        public ProductContext CreateDbContext(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true)
                .AddJsonFile("appsettings.Development.json", optional: true)
                .AddEnvironmentVariables()
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<ProductContext>();

            optionsBuilder.UseSqlServer(
                configuration.GetConnectionString("ProductDatabase")
            );

            return new ProductContext(optionsBuilder.Options);
        }
    }
}