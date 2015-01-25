using PeopleManager.Common.Entities;
using PeopleManager.Common.Repositories;
using System.Collections.Generic;
using System.Web.Http;

namespace PeopleManager.API.Controllers
{
    public class PersonController : ApiController
    {
        private readonly IPersonRepository _personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            this._personRepository = personRepository;
        }

        /// <summary>
        /// /api/person/list
        /// </summary>
        [HttpGet]
        public IList<Person> List()
        {
            return this._personRepository.List();
        }
    }
}
