using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PeopleManager.API.Controllers;
using PeopleManager.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManager._Tests.API
{
    [TestClass]
    public class PersonControllerTests
    {
        private Mock<IPersonRepository> MockPersonRepository { get; set; }

        /// <summary>
        /// Verify that List() method calls IPersonRepository.List().
        /// </summary>
        [TestMethod]
        public void List_Calls_Repository_List()
        {
            //given
            this.MockPersonRepository = new Mock<IPersonRepository>();
            PersonController controller = new PersonController(this.MockPersonRepository.Object);

            //when
            controller.List();

            //then
            this.MockPersonRepository.Verify(repo => repo.List());
        }
    }
}
