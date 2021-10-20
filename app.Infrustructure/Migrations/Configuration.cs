namespace app.Infrustructure.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<app.Infrustructure.Context.AppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(app.Infrustructure.Context.AppContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            //context.students.Add(new Models.Student { Name="Shakil",Address="Chotopool",Contact="01965401372",Email="sfshakilahmed@gmail.com"});
            //context.SaveChanges();
        }
    }
}
