namespace FriendOrganizer.DataAccess.Migrations
{
    using FriendOrganizer.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FriendOrganizer.DataAccess.FriendOrganizerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FriendOrganizer.DataAccess.FriendOrganizerDbContext context)
        {
            context.Friends.AddOrUpdate(
                f => f.FirstName,
                new Friend { FirstName = "Kenan", LastName = "Alic" },
                new Friend { FirstName = "Bosse", LastName = "Kaffekopp" },
                new Friend { FirstName = "Nils", LastName = "Pyssling" },
                new Friend { FirstName = "Thomas", LastName = "Huber" }
                );
        }
    }
}
