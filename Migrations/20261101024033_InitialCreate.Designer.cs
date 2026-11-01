using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductsApi.Data;

#nullable disable

namespace ProductsApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20261101024033_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "10.0.13");

            modelBuilder.Entity("ProductsApi.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mouse inalámbrico",
                            Price = 3999.99m
                        },
                        new
                        {
                            Id = 2,
                            Name = "Teclado mecánico",
                            Price = 8299.50m
                        },
                        new
                        {
                            Id = 3,
                            Name = "Monitor 24 pulgadas",
                            Price = 52499.00m
                        },
                        new
                        {
                            Id = 4,
                            Name = "Notebook Dell Inspiron",
                            Price = 185000.00m
                        },
                        new
                        {
                            Id = 5,
                            Name = "Auriculares Bluetooth",
                            Price = 10499.90m
                        },
                        new
                        {
                            Id = 6,
                            Name = "Webcam HD",
                            Price = 7999.00m
                        },
                        new
                        {
                            Id = 7,
                            Name = "Silla ergonómica",
                            Price = 61200.00m
                        },
                        new
                        {
                            Id = 8,
                            Name = "Disco SSD 1TB",
                            Price = 44999.99m
                        },
                        new
                        {
                            Id = 9,
                            Name = "Tablet Samsung Galaxy",
                            Price = 93499.00m
                        },
                        new
                        {
                            Id = 10,
                            Name = "Impresora multifunción",
                            Price = 73900.00m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
