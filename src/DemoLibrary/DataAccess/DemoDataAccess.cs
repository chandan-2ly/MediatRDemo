using DemoLibrary.Models;
using System.Collections.Generic;
using System.Linq;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModel> people = new();

        public DemoDataAccess()
        {
            people.Add(new PersonModel { Id = 1, FirstName = "Chandan", LastName = "Sah" });
            people.Add(new PersonModel { Id = 2, FirstName = "Kundan", LastName = "Sah" });
        }

        public List<PersonModel> GetPeople()
        {
            return people;
        }

        public PersonModel InsertPerson(string firstName, string lastName)
        {
            PersonModel p = new() { Id = people.Max(x => x.Id) + 1, FirstName = firstName, LastName = lastName };
            people.Add(p);
            return p;
        }
    }
}
