namespace YesilliOkul.DATA.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<YesilliOkul.DATA.Context.YesilliOkulContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true; // otomatik migration yapmak için true ya çektik (add migration yapabilmek için)
        }

        protected override void Seed(YesilliOkul.DATA.Context.YesilliOkulContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
