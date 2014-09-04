using Autofac;
using Autofac.Core;
using Autofac.Integration.Mvc;
using DIPSky.Core.Data;
using DIPSky.Core.Infrastructure;
using DIPSky.Core.Infrastructure.DependencyManagement;
using DIPSky.Data;
using DIPSky.Plugin.Shipping.ByWeight.Data;
using DIPSky.Plugin.Shipping.ByWeight.Domain;
using DIPSky.Plugin.Shipping.ByWeight.Services;

namespace DIPSky.Plugin.Shipping.ByWeight
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
            builder.RegisterType<ShippingByWeightService>().As<IShippingByWeightService>().InstancePerHttpRequest();

            //data layer
            var dataSettingsManager = new DataSettingsManager();
            var dataProviderSettings = dataSettingsManager.LoadSettings();

            if (dataProviderSettings != null && dataProviderSettings.IsValid())
            {
                //register named context
                builder.Register<IDbContext>(c => new ShippingByWeightObjectContext(dataProviderSettings.DataConnectionString))
                    .Named<IDbContext>("DIPSky_object_context_shipping_weight_zip")
                    .InstancePerHttpRequest();

                builder.Register<ShippingByWeightObjectContext>(c => new ShippingByWeightObjectContext(dataProviderSettings.DataConnectionString))
                    .InstancePerHttpRequest();
            }
            else
            {
                //register named context
                builder.Register<IDbContext>(c => new ShippingByWeightObjectContext(c.Resolve<DataSettings>().DataConnectionString))
                    .Named<IDbContext>("DIPSky_object_context_shipping_weight_zip")
                    .InstancePerHttpRequest();

                builder.Register<ShippingByWeightObjectContext>(c => new ShippingByWeightObjectContext(c.Resolve<DataSettings>().DataConnectionString))
                    .InstancePerHttpRequest();
            }

            //override required repository with our custom context
            builder.RegisterType<EfRepository<ShippingByWeightRecord>>()
                .As<IRepository<ShippingByWeightRecord>>()
                .WithParameter(ResolvedParameter.ForNamed<IDbContext>("DIPSky_object_context_shipping_weight_zip"))
                .InstancePerHttpRequest();
        }

        public int Order
        {
            get { return 1; }
        }
    }
}
