using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using unity_getting_started.Services.Contracts;
using unity_getting_started.Services;

namespace unity_getting_started
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<IFooService, FooService>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}