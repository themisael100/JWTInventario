namespace JWTInventario.Auth
{
    public interface IJwtAuthenticationService
    {
        string Authenticate(string userName);
    }
}
