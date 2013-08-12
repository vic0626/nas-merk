//Contributor:  Nicholas Mayne


namespace Nas.Services.Authentication.External
{
    public partial interface IClaimsTranslator<T>
    {
        UserClaims Translate(T response);
    }
}