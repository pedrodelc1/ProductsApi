using Microsoft.EntityFrameworkCore;
using ProductsApi.Entities;

namespace ProductsApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products => Set<Product>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Mouse inalámbrico", Price = 3999.99m },
            new Product { Id = 2, Name = "Teclado mecánico", Price = 8299.50m },
            new Product { Id = 3, Name = "Monitor 24 pulgadas", Price = 52499.00m },
            new Product { Id = 4, Name = "Notebook Dell Inspiron", Price = 185000.00m },
            new Product { Id = 5, Name = "Auriculares Bluetooth", Price = 10499.90m },
            new Product { Id = 6, Name = "Webcam HD", Price = 7999.00m },
            new Product { Id = 7, Name = "Silla ergonómica", Price = 61200.00m },
            new Product { Id = 8, Name = "Disco SSD 1TB", Price = 44999.99m },
            new Product { Id = 9, Name = "Tablet Samsung Galaxy", Price = 93499.00m },
            new Product { Id = 10, Name = "Impresora multifunción", Price = 73900.00m });
    }
}
