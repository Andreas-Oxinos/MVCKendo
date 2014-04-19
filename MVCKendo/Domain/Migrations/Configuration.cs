using System.Collections.ObjectModel;

namespace Domain.Migrations
{
    using Domain.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Domain.Context.PersonContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Domain.Context.PersonContext context)
        {
            context.Persons.AddOrUpdate(
                p => p.Id,
                    new Person { Name = "Andreas", Surname = "Oxinos", pet = new Collection<Pet>
                    {
                         new Pet { Age = 1, Name = "Lufy"},
                         new Pet { Age = 1, Name = "Sandy"}

                    }},
                    new Person { Name = "Vaso", Surname = "Alexogrlou" }
            );
        }
    }
}
