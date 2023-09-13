using JWTInventario.Auth;

namespace JWTInventario.Endpoints
{
        public static class AccountEndpoint
        {
            public static void AddAccountEndoints(this WebApplication app)
            {
                app.MapPost("/account/login", (string login, string password, IJwtAuthenticationService authservice) =>
                {
                    if (login == "admin" && password == "12345")
                    {
                        var token = authservice.Authenticate(login);

                        return Results.Ok(token);
                    }
                    else
                    {
                        return Results.Unauthorized();
                    }
                });
            }
        }
}
