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
    [Migration("20191011214903_Newforeignkeys")]
    partial class Newforeignkeys
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
                        .HasColumnType("varchar(10)");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<bool>("isActive");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("saleId");

                    b.HasKey("id");

                    b.HasIndex("saleId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("CustomerMangerAPI.Models.Sale", b =>
                {
                    b.Property<int>("saleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SaleLineId");

                    b.Property<string>("saleDate");

                    b.HasKey("saleId");

                    b.HasIndex("SaleLineId");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("CustomerMangerAPI.Models.SaleLine", b =>
                {
                    b.Property<int>("saleLineId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("productId");

                    b.Property<string>("quantity");

                    b.Property<int>("totalQuantity");

                    b.HasKey("saleLineId");

                    b.HasIndex("productId");

                    b.ToTable("SaleLine");
                });

            modelBuilder.Entity("CustomerMangerAPI.Models.product", b =>
                {
                    b.Property<int>("productId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("productName");

                    b.Property<int>("unitPrice");

                    b.HasKey("productId");

                    b.ToTable("product");
                });

            modelBuilder.Entity("CustomerMangerAPI.Models.Customer", b =>
                {
                    b.HasOne("CustomerMangerAPI.Models.Sale", "Sale")
                        .WithMany()
                        .HasForeignKey("saleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CustomerMangerAPI.Models.Sale", b =>
                {
                    b.HasOne("CustomerMangerAPI.Models.SaleLine", "saleLine")
                        .WithMany()
                        .HasForeignKey("SaleLineId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CustomerMangerAPI.Models.SaleLine", b =>
                {
                    b.HasOne("CustomerMangerAPI.Models.product", "product")
                        .WithMany()
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
