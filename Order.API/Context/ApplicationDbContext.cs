using Microsoft.EntityFrameworkCore;
using Order.API.Models;

namespace Order.API.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Models.Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Models.Order>()
                .Property(p => p.TotalPrice)
                .HasColumnType("decimal(18,4)");
            modelBuilder.Entity<Models.OrderItem>()
             .Property(p => p.Price)
             .HasColumnType("decimal(18,4)");
        }
    }
}
