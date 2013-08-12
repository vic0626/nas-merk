using Autofac;
using Autofac.Core;
using Autofac.Integration.Mvc;
using Nas.Core.Data;
using Nas.Core.Infrastructure;
using Nas.Core.Infrastructure.DependencyManagement;
using Nas.Data;
using Nas.Plugin.Tax.CountryStateZip.Data;
using Nas.Plugin.Tax.CountryStateZip.Domain;
using Nas.Plugin.Tax.CountryStateZip.Services;

namespace Nas.Plugin.Tax.CountryStateZip
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
            builder.RegisterType<TaxRateService>().As<ITaxRateService>().InstancePerHttpRequest();

            //data layer
            var dataSettingsManager = new DataSettingsManager();
            var dataProviderSettings = dataSettingsManager.LoadSettings();

            if (dataProviderSettings != null && dataProviderSettings.IsValid())
            {
                //register named context
                builder.Register<IDbContext>(c => new TaxRateObjectContext(dataProviderSettings.DataConnectionString))
                    .Named<IDbContext>("Nas_object_context_tax_country_state_zip")
                    .InstancePerHttpRequest();

                builder.Register<TaxRateObjectContext>(c => new TaxRateObjectContext(dataProviderSettings.DataConnectionString))
                    .InstancePerHttpRequest();
            }
            else
            {
                //register named context
                builder.Register<IDbContext>(c => new TaxRateObjectContext(c.Resolve<DataSettings>().DataConnectionString))
                    .Named<IDbContext>("Nas_object_context_tax_country_state_zip")
                    .InstancePerHttpRequest();

                builder.Register<TaxRateObjectContext>(c => new TaxRateObjectContext(c.Resolve<DataSettings>().DataConnectionString))
                    .InstancePerHttpRequest();
            }

            //override required repository with our custom context
            builder.RegisterType<EfRepository<TaxRate>>()
                .As<IRepository<TaxRate>>()
                .WithParameter(ResolvedParameter.ForNamed<IDbContext>("Nas_object_context_tax_country_state_zip"))
                .InstancePerHttpRequest();
        }

        public int Order
        {
            get { return 1; }
        }
    }
}
