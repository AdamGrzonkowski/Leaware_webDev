namespace SL.Model.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SL.Model.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "SL.Model.ApplicationDbContext";
        }

        protected override void Seed(SL.Model.ApplicationDbContext context)
        {
        }
    }
}
