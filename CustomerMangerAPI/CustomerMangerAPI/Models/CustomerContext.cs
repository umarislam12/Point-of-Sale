using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerMangerAPI.Models
{
    public class CustomerContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<SaleLine> SaleLine { get; set; }
        public DbSet<product> product { get; set; }
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SaleLine>().HasKey(SL => new { SL.saleId, SL.productId });
        }





    }
}