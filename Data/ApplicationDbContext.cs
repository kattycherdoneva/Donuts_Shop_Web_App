using System;
using System.Collections.Generic;
using System.Text;
using DonutsShopApp.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DonutsShopApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {        
        public DbSet<Donation> Donations { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<ProductForReceipt> ProductForReceipts { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Shipping> Shippings { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
