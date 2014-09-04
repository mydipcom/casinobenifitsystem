using Autofac;
using Autofac.Integration.Mvc;
using DIPSky.Core.Infrastructure;
using DIPSky.Core.Infrastructure.DependencyManagement;
using DIPSky.Plugin.ExternalAuth.Facebook.Core;

namespace DIPSky.Plugin.ExternalAuth.Facebook
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
            builder.RegisterType<FacebookProviderAuthorizer>().As<IOAuthProviderFacebookAuthorizer>().InstancePerHttpRequest();
        }

        public int Order
        {
            get { return 1; }
        }
    }
}
