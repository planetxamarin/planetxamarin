using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;

namespace Firehose.Web.App_Start
{
    public static class ContainerConfig
    {
        private static IContainer _container;

        public static void Configure()
        {
            _container = IoC.LetThereBeIoC();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(_container));
        }

        public static void TearDown()
        {
            var container = _container;
            if (container != null) container.Dispose();
        }
    }
}