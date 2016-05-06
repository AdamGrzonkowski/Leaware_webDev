using System.Data.Entity;
using SL.Core.Domain.Orders;
using SL.Core.Domain.Products;
using SL.Core.Domain.Users;
using SL.Model.Migrations;

namespace SL.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>();
            modelBuilder.Entity<Books>();
            modelBuilder.Entity<Cart>();
            modelBuilder.Entity<Order>();
            modelBuilder.Entity<OrderDetail>();
            modelBuilder.Entity<Shipment>();
        }
    }
}