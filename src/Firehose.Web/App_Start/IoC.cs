using Autofac;

namespace Firehose.Web.App_Start
{
    public static class IoC
    {
        public static IContainer LetThereBeIoC()
        {
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyModules(typeof (IoC).Assembly);
            return builder.Build();
        }
    }
}