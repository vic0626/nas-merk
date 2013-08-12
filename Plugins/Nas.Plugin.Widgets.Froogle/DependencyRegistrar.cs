using Autofac;
using Autofac.Core;
using Autofac.Integration.Mvc;
using Nas.Core.Data;
using Nas.Core.Infrastructure;
using Nas.Core.Infrastructure.DependencyManagement;
using Nas.Data;
using Nas.Plugin.Feed.Froogle.Data;
using Nas.Plugin.Feed.Froogle.Domain;
using Nas.Plugin.Feed.Froogle.Services;

namespace Nas.Plugin.Feed.Froogle
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
                    .Named<IDbContext>("Nas_object_context_google_product")
                    .InstancePerHttpRequest();

                builder.Register<GoogleProductObjectContext>(c => new GoogleProductObjectContext(dataProviderSettings.DataConnectionString))
                    .InstancePerHttpRequest();
            }
            else
            {
                //register named context
                builder.Register<IDbContext>(c => new GoogleProductObjectContext(c.Resolve<DataSettings>().DataConnectionString))
                    .Named<IDbContext>("Nas_object_context_google_product")
                    .InstancePerHttpRequest();

                builder.Register<GoogleProductObjectContext>(c => new GoogleProductObjectContext(c.Resolve<DataSettings>().DataConnectionString))
                    .InstancePerHttpRequest();
            }

            //override required repository with our custom context
            builder.RegisterType<EfRepository<GoogleProductRecord>>()
                .As<IRepository<GoogleProductRecord>>()
                .WithParameter(ResolvedParameter.ForNamed<IDbContext>("Nas_object_context_google_product"))
                .InstancePerHttpRequest();
        }

        public int Order
        {
            get { return 1; }
        }
    }
}
