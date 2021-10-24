using System.Web.Http;
using Unity;
using Unity.WebApi;
using winelegend.service.Repositary;
using winelegend.service.services;

namespace winelegend.service
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IRoleService, RoleRepositary>();
            container.RegisterType<IStudentService, StudentRepositary>();
            container.RegisterType<ICategoryService, CategoryRepositary>();
            container.RegisterType<ISubCategoryService, SubCategoryRepositary>();
            container.RegisterType<IBrandService, BrandRepositary>();
            container.RegisterType<IUserService, UsersRepositary>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}