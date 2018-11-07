using MYARCH.CORE;
using MYARCH.DATA.GenericRepository;
using System.Web.Mvc;
using Unity;
using Unity.Lifetime;
using Unity.Mvc5;

namespace MYARCH.IoC
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            container.BindInRequestScope<IGenericRepository<User>, GenericRepository<User>>();
            container.BindInRequestScope<IGenericRepository<Post>, GenericRepository<Post>>();
            container.BindInRequestScope<IGenericRepository<Category>, GenericRepository<Category>>();
        }

        public static void BindInRequestScope<T1, T2>(this IUnityContainer container) where T2 : T1
        {
            container.RegisterType<T1, T2>(new HierarchicalLifetimeManager());
        }

    }
}