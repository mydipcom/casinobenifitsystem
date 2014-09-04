using Autofac;
using Autofac.Integration.Mvc;
using DIPSky.Core.Infrastructure;
using DIPSky.Core.Infrastructure.DependencyManagement;
using DIPSky.Plugin.ExternalAuth.OpenId.Core;

namespace DIPSky.Plugin.ExternalAuth.OpenId
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
            builder.RegisterType<OpenIdProviderAuthorizer>().As<IOpenIdProviderAuthorizer>().InstancePerHttpRequest();
            builder.RegisterType<OpenIdRelyingPartyService>().As<IOpenIdRelyingPartyService>().InstancePerHttpRequest();
        }

        public int Order
        {
            get { return 1; }
        }
    }
}
