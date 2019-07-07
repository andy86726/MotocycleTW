namespace MotocycleTW.Migrations
{
    using MotocycleTW.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MotocycleTW.Models.MotocycleContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MotocycleTW.Models.MotocycleContext context)
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
            context.Categories.AddOrUpdate(
                p => p.c_id,
                new Category { c_id = 1, c_name = "Battery" },
                new Category { c_id = 2, c_name = "Electric_motor_car" },
                new Category { c_id = 3, c_name = "Helment" },
                new Category { c_id = 4, c_name = "Mat" },
                new Category { c_id = 5, c_name = "Rear_Carrier" },
                new Category { c_id = 6, c_name = "Fender" }
                );
        }
    }
}
