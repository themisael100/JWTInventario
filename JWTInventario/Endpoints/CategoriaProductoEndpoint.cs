namespace JWTInventario.Endpoints
{
    public static class CategoriaProductoEndpoint
    {
        static List<Object> data = new List<object>();

        public static void AddCategoriaProductoEndpoint(this WebApplication app)
        {
            app.MapGet("/CategoriaProducto", () =>
            {
                return data;
            });

            app.MapPost("/CategoriaProducto", (string nameCategori) =>
            {
                data.Add(new { nameCategori });

                return Results.Ok();
            }).RequireAuthorization();
        }
    }
}
