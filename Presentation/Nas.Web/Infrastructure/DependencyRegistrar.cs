using Autofac;
using Autofac.Core;
using Autofac.Integration.Mvc;
using Nas.Core.Caching;
using Nas.Core.Infrastructure;
using Nas.Core.Infrastructure.DependencyManagement;
using Nas.Web.Controllers;
using Nas.Web.Infrastructure.Installation;

namespace Nas.Web.Infrastructure
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
            //we cache presentation models between requests
            builder.RegisterType<BlogController>()
                .WithParameter(ResolvedParameter.ForNamed<ICacheManager>("Nas_cache_static"));
            builder.RegisterType<CatalogController>()
                .WithParameter(ResolvedParameter.ForNamed<ICacheManager>("Nas_cache_static"));
            builder.RegisterType<CountryController>()
                .WithParameter(ResolvedParameter.ForNamed<ICacheManager>("Nas_cache_static"));
            builder.RegisterType<CommonController>()
                .WithParameter(ResolvedParameter.ForNamed<ICacheManager>("Nas_cache_static"));
            builder.RegisterType<NewsController>()
                .WithParameter(ResolvedParameter.ForNamed<ICacheManager>("Nas_cache_static"));
            builder.RegisterType<PollController>()
                .WithParameter(ResolvedParameter.ForNamed<ICacheManager>("Nas_cache_static"));
            builder.RegisterType<ShoppingCartController>()
                .WithParameter(ResolvedParameter.ForNamed<ICacheManager>("Nas_cache_static"));
            builder.RegisterType<TopicController>()
                .WithParameter(ResolvedParameter.ForNamed<ICacheManager>("Nas_cache_static"));
            
            //installation localization service
            builder.RegisterType<InstallationLocalizationService>().As<IInstallationLocalizationService>().InstancePerHttpRequest();
        }

        public int Order
        {
            get { return 2; }
        }
    }
}
