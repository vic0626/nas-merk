//Contributor:  Nicholas Mayne


using Nas.Services.Authentication.External;

namespace Nas.Plugin.ExternalAuth.OpenId.Core
{
    public interface IOpenIdProviderAuthorizer : IExternalProviderAuthorizer
    {
        string EnternalIdentifier { get; set; } // mayne - refactor this out
        bool IsOpenIdCallback { get; }
    }
}