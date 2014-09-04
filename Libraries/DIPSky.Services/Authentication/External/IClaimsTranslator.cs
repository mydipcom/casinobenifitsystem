//Contributor:  Nicholas Mayne


namespace DIPSky.Services.Authentication.External
{
    public partial interface IClaimsTranslator<T>
    {
        UserClaims Translate(T response);
    }
}