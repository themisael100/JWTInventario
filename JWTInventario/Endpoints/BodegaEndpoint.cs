using JWTInventario.Models;
namespace JWTInventario.Endpoints
{
    public static class BodegaEndpoint
    {
        static List<Bodega> bodega = new List<Bodega>();

        public static void AddBodegaEndpoint(this WebApplication app)
        {
            app.MapPost("/Bodega", (int Id, string name, string description) =>
            {
                bodega.Add(new Bodega { Id = Id, Name = name, Description = description });
                return Results.Ok();
            }).RequireAuthorization();


            app.MapPut("/Bodega/{id}", (int id, string name, string description) =>
            {
                var existingBodega = bodega.FirstOrDefault(B => B.Id == id);
                if (existingBodega != null)
                {
                    existingBodega.Name = name;
                    existingBodega.Description = description;
                }
                return Results.Ok();
            }).RequireAuthorization();

            app.MapGet("/Bodega/{id}", (int id) =>
            {
                var resultBodega = bodega.FirstOrDefault(B => B.Id == id);
                if (resultBodega != null)
                {
                    return Results.Ok(resultBodega);
                }
                else
                {
                    return Results.NotFound();
                }
            }).RequireAuthorization();
        }
    }
}

