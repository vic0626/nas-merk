using Autofac;
using Autofac.Integration.Mvc;
using Nas.Core.Infrastructure;
using Nas.Core.Infrastructure.DependencyManagement;
using Nas.Plugin.ExternalAuth.Facebook.Core;

namespace Nas.Plugin.ExternalAuth.Facebook
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
