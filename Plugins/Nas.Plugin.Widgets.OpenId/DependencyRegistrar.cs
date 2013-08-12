using Autofac;
using Autofac.Integration.Mvc;
using Nas.Core.Infrastructure;
using Nas.Core.Infrastructure.DependencyManagement;
using Nas.Plugin.ExternalAuth.OpenId.Core;

namespace Nas.Plugin.ExternalAuth.OpenId
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
