namespace MVCStorage.Migrations
{
    using MVCStorage.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCStorage.Models.MVCStorageContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MVCStorage.Models.MVCStorageContext";
        }

        protected override void Seed(MVCStorage.Models.MVCStorageContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Items.AddOrUpdate(
              i => i.Name,
             new Item { Name = "Datormus", Brand="Logitech", Model="MX-100n", Count=47, Price=189.50m },
             new Item { Name = "Skärm", Brand="Phillips", Model="GX-100", Count=7, Price=369.50m },
             new Item { Name = "HårdDisk", Brand="Seagate", Model="FM-709", Count=10, Price=200.50m },
             new Item { Name = "Speakers", Brand="Logitech", Model="U-200n", Count=4, Price=100.50m },
             new Item { Name = "USB", Brand="Nintex", Model="F-024", Count=700, Price=39.50m },
             new Item { Name = "DVD", Brand="Dell", Model="D-10", Count=100, Price=180.50m }
            );
            
        }
    }
}
