using System.Data.Entity;
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

        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Books> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>();
            modelBuilder.Entity<Books>();   
        }
    }
}