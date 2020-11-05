using HandsOnTest.BLL.EmployeeBLL;
using HandsOnTest.DAL;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace HandsOnTest
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IEmployeeBLL, EmployeeBLL>();
            container.RegisterType<IEmployeeRepository, EmployeeRepository>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}