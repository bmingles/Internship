using PeopleManager.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PeopleManager.Common.Repositories
{
    public class TestPersonRepository: IPersonRepository
    {
        private readonly IList<Person> _people;

        public TestPersonRepository()
        {
            this._people = new List<Person>
            {
                new Person { ID = 1, FirstName = "John", LastName = "Doe" },
                new Person { ID = 2, FirstName = "Jill", LastName = "Smith" }
            };
        }

        public Person Get(int id)
        {
            return this._people.FirstOrDefault(person => person.ID == id);
        }

        public IList<Person> List()
        {
            return this._people;
        }

        public void AddOrUpdate(Person person)
        {
            this._people.Add(person);
        }
    }
}
