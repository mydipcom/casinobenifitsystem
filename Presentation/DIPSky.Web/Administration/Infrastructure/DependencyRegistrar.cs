using Autofac;
using Autofac.Core;
using DIPSky.Admin.Controllers;
using DIPSky.Core.Caching;
using DIPSky.Core.Infrastructure;
using DIPSky.Core.Infrastructure.DependencyManagement;

namespace DIPSky.Admin.Infrastructure
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
            //we cache presentation models between requests
            builder.RegisterType<HomeController>()
                .WithParameter(ResolvedParameter.ForNamed<ICacheManager>("DIPSky_cache_static"));
        }

        public int Order
        {
            get { return 2; }
        }
    }
}
