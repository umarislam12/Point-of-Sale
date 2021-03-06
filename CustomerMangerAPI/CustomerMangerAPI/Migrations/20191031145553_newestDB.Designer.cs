﻿// <auto-generated />
using CustomerMangerAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CustomerMangerAPI.Migrations
{
    [DbContext(typeof(CustomerContext))]
    [Migration("20191031145553_newestDB")]
    partial class newestDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CustomerMangerAPI.Models.Customer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("dateOfBirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<bool>("isActive");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("CustomerMangerAPI.Models.Sale", b =>
                {
                    b.Property<int>("saleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("id");

                    b.Property<string>("saleDate");

                    b.Property<int>("saleNo");

                    b.HasKey("saleId");

                    b.HasIndex("id");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("CustomerMangerAPI.Models.SaleLine", b =>
                {
                    b.Property<int>("saleLineId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("productId");

                    b.Property<int>("quantity");

                    b.Property<int>("saleId");

                    b.Property<int>("totalQuantity");

                    b.HasKey("saleLineId");

                    b.HasIndex("productId");

                    b.HasIndex("saleId");

                    b.ToTable("SaleLine");
                });

            modelBuilder.Entity("CustomerMangerAPI.Models.product", b =>
                {
                    b.Property<int>("productId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("productCode");

                    b.Property<string>("productName");

                    b.Property<int>("unitPrice");

                    b.HasKey("productId");

                    b.ToTable("product");
                });

            modelBuilder.Entity("CustomerMangerAPI.Models.Sale", b =>
                {
                    b.HasOne("CustomerMangerAPI.Models.Customer", "Customer")
                        .WithMany("Sales")
                        .HasForeignKey("id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CustomerMangerAPI.Models.SaleLine", b =>
                {
                    b.HasOne("CustomerMangerAPI.Models.product", "product")
                        .WithMany("SaleLines")
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CustomerMangerAPI.Models.Sale", "Sale")
                        .WithMany()
                        .HasForeignKey("saleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
