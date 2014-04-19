using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
namespace Domain.Context
{
    public class PersonContext : DbContext
    {
        public PersonContext()
            : base("PeopleContext")
        {

        }
        public DbSet<Person> Persons { get; set; }
    }
}
