using Autofac;
using Autofac.Core;
using Autofac.Integration.Mvc;
using DIPSky.Core.Data;
using DIPSky.Core.Infrastructure;
using DIPSky.Core.Infrastructure.DependencyManagement;
using DIPSky.Data;
using DIPSky.Plugin.Feed.Froogle.Data;
using DIPSky.Plugin.Feed.Froogle.Domain;
using DIPSky.Plugin.Feed.Froogle.Services;

namespace DIPSky.Plugin.Feed.Froogle
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
            builder.RegisterType<GoogleService>().As<IGoogleService>().InstancePerHttpRequest();

            //data layer
            var dataSettingsManager = new DataSettingsManager();
            var dataProviderSettings = dataSettingsManager.LoadSettings();

            if (dataProviderSettings != null && dataProviderSettings.IsValid())
            {
                //register named context
                builder.Register<IDbContext>(c => new GoogleProductObjectContext(dataProviderSettings.DataConnectionString))
                    .Named<IDbContext>("DIPSky_object_context_google_product")
                    .InstancePerHttpRequest();

                builder.Register<GoogleProductObjectContext>(c => new GoogleProductObjectContext(dataProviderSettings.DataConnectionString))
                    .InstancePerHttpRequest();
            }
            else
            {
                //register named context
                builder.Register<IDbContext>(c => new GoogleProductObjectContext(c.Resolve<DataSettings>().DataConnectionString))
                    .Named<IDbContext>("DIPSky_object_context_google_product")
                    .InstancePerHttpRequest();

                builder.Register<GoogleProductObjectContext>(c => new GoogleProductObjectContext(c.Resolve<DataSettings>().DataConnectionString))
                    .InstancePerHttpRequest();
            }

            //override required repository with our custom context
            builder.RegisterType<EfRepository<GoogleProductRecord>>()
                .As<IRepository<GoogleProductRecord>>()
                .WithParameter(ResolvedParameter.ForNamed<IDbContext>("DIPSky_object_context_google_product"))
                .InstancePerHttpRequest();
        }

        public int Order
        {
            get { return 1; }
        }
    }
}
