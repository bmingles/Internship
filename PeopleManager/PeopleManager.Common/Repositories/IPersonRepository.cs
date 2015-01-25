using PeopleManager.Common.Entities;
using System.Collections.Generic;

namespace PeopleManager.Common.Repositories
{
    public interface IPersonRepository
    {
        Person Get(int id);
        IList<Person> List();
        void AddOrUpdate(Person person);
    }
}
