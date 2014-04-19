using Domain.Context;
using Domain.Models;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DAL
{
    public class PersonDAL : IDisposable
    {
        public IEnumerable<PersonVM> GetData()
        {
            var myData = new List<PersonVM>();
            using(var context = new PersonContext())
            {
                myData =  (from r in context.Persons
                          select new PersonVM
                          {
                              PersonId = r.Id,
                              Name = r.Name,
                              Surname = r.Surname
                          }).ToList();
            }
            return myData;
        }

        public void AddData(PersonVM person)
        {
            using(var context = new PersonContext())
            {
                context.Persons.Add(new Person { Name = person.Name, Surname = person.Surname });
                context.SaveChanges();
            }
        }


        public void EditData(PersonVM person)
        {
            using (var context = new PersonContext())
            {
                var model = context.Persons.FirstOrDefault(x => x.Id == person.PersonId);
                model.Name = person.Name;
                model.Surname = person.Surname;
                context.SaveChanges();
            }
        }

        public void DeleteData(PersonVM person)
        {
            using(var context = new PersonContext())
            {
                context.Persons.Remove(context.Persons.FirstOrDefault(x => x.Id == person.PersonId));
                context.SaveChanges();
            }
        }

        public void Dispose()
        {
            
        }
    }
}
