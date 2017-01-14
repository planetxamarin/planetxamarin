using Autofac;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.AutofacModules
{
    public class FeedsModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterAssemblyTypes(ThisAssembly)
                   .Where(t => t.IsAssignableTo<IAmACommunityMember>())
                   .AsImplementedInterfaces()
                   .SingleInstance();

            builder.RegisterType<CombinedFeedSource>()
                   .AsSelf()
                   .SingleInstance();
        }
    }
}