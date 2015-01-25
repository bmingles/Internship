using Microsoft.Practices.Unity;
using PeopleManager.API.IoC;
using PeopleManager.Common.Repositories;
using System.Web.Http;

namespace PeopleManager.API.App_Start
{
    public static class DependencyResolutionConfig
    {
        /// <summary>
        /// IoC configuration is based on article here: http://www.asp.net/web-api/overview/advanced/dependency-injection
        /// </summary>
        /// <param name="httpConfig"></param>
        public static void Register(HttpConfiguration httpConfig)
        {
            //create container
            IUnityContainer container = new UnityContainer();

            //register types
            container.RegisterType<IPersonRepository, TestPersonRepository>(new HierarchicalLifetimeManager());

            httpConfig.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}