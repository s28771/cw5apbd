using ap5.Database;
using ap5.Models;

namespace ap5.Endpoints;

public static class AnimalEndpoints
{
    public static void MapAnimalEndpoints(this WebApplication app)
    {
        // Minimal API
        app.MapGet("/animals", () =>
        {
            //200 - Ok
            //400 - Bad Request
            //401 - Unauthorized
            //402
            //403 - Forbiden
            //404 - Not found
            //500 - Internal Server Error (błąd servera)

            var animals = StaticData.animals;
            return Results.Ok(animals);
        });
        app.MapGet("/animals/{id}", (int id) =>
        {
            return Results.Ok(id);
        });
        
        app.MapPost("/animals", (Animal animal) =>
        {
            //201 - Created
            return Results.Created("",animal);
        });

    }
}