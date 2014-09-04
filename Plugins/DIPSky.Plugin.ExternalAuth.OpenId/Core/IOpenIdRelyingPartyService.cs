//Contributor:  Nicholas Mayne


using DotNetOpenAuth.OpenId.RelyingParty;

namespace DIPSky.Plugin.ExternalAuth.OpenId.Core
{
    public interface IOpenIdRelyingPartyService
    {
        IAuthenticationResponse Response { get; }
        IAuthenticationRequest CreateRequest(OpenIdIdentifier openIdIdentifier);
        bool HasResponse { get; }
    }
}