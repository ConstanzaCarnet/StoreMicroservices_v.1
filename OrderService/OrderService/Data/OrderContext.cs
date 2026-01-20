using Microsoft.EntityFrameworkCore;
using OrderService.Model;

namespace OrderService.Data
{
    public class OrderContext : DbContext
    {
        //creo el constructor
        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {

        }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(o => o.Id);
                entity.Property(o => o.ProductId)
                      .IsRequired();
                entity.Property(o => o.TotalPrice)
                      .HasColumnType("decimal(18,2)");
            });
        }
    }
}
