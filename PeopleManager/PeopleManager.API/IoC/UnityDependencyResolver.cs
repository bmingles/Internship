using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;

namespace PeopleManager.API.IoC
{
    /// <summary>
    /// Modified version of resolver found in this article: http://www.asp.net/web-api/overview/advanced/dependency-injection
    /// </summary>
    public class UnityDependencyResolver: IDependencyResolver
    {
        private readonly IUnityContainer _container;

        public UnityDependencyResolver(IUnityContainer container)
        {
            if(container == null)
            {
                throw new ArgumentNullException("container");
            }

            this._container = container;
        }
               
        public object GetService(Type serviceType)
        {
            try
            {
                return this._container.Resolve(serviceType);
            }
            catch(ResolutionFailedException)
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return this._container.ResolveAll(serviceType);
            }
            catch (ResolutionFailedException)
            {
                return new List<object>();
            }
        }

        public IDependencyScope BeginScope()
        {
            IUnityContainer childContainer = this._container.CreateChildContainer();
            return new UnityDependencyResolver(childContainer);
        }

        public void Dispose()
        {
            this._container.Dispose();
        }
    }
}