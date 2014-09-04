//Contributor:  Nicholas Mayne


using DIPSky.Services.Authentication.External;

namespace DIPSky.Plugin.ExternalAuth.OpenId.Core
{
    public interface IOpenIdProviderAuthorizer : IExternalProviderAuthorizer
    {
        string EnternalIdentifier { get; set; } // mayne - refactor this out
        bool IsOpenIdCallback { get; }
    }
}