using PeopleManager.Common.Entities;
using PeopleManager.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManager.WinForms.Repositories
{
    /// <summary>
    /// Sample here on using HttpClient to connect to Web API:
    /// http://www.asp.net/web-api/overview/advanced/calling-a-web-api-from-a-net-client
    /// </summary>
    public class HttpPersonRepository: IPersonRepository
    {
        public IList<Person> List()
        {
            using(HttpClient client = new HttpClient())
            {
                IList<Person> people = null;

                client.BaseAddress = new Uri("http://localhost:51278/"); //web api url
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/person/list").Result;
                if(response.IsSuccessStatusCode)
                {
                    people = response.Content.ReadAsAsync<IList<Person>>().Result;
                }

                return people;
            }
        }

        public Person Get(int id)
        {
            throw new NotImplementedException();
        }

        public void AddOrUpdate(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
