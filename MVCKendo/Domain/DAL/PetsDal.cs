using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Context;
using Domain.Models;
using Domain.ViewModels;

namespace Domain.DAL
{
    public class PetsDal : IDisposable
    {
        public List<PetVW> Get(int personId)
        {
            using (var context = new PersonContext())
            {
                return (from r in context.Pets
                        where r.person.Id == personId
                        select new PetVW
                        {
                            Age = r.Age,
                            Name = r.Name,
                            PetId = r.Id,
                            PersonId = r.person.Id
                        }).ToList();
            }
        }

        public void Create(PetVW pet)
        {
            using (var context = new PersonContext())
            {

                var _person = context.Persons.FirstOrDefault(x => x.Id == pet.PersonId);
                context.Pets.Add(new Pet
                {
                    Name = pet.Name,
                    person = _person,
                    Age = pet.Age
                });
                context.SaveChanges();
            }
        }

        public void Dispose()
        {
        }
    }
}
