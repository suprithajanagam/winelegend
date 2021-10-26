using System;
using System.Web.Http;
using System.Web.Mvc;
using Unity;
using Unity.AspNet.Mvc;
using winelegend.web.Repository;
using winelegend.web.Services;

namespace winelegend.web
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IStudentService, StudentRepository>();
            container.RegisterType<ILanguageService, LanguageRepositary>();
            container.RegisterType<IRoleService, RoleRepositary>();
            container.RegisterType<ILanguageService, LanguageRepositary>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}