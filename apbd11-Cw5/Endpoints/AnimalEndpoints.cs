// using apbd11_Cw5.database;
// using apbd11_Cw5.Models;
//
// namespace apbd11_Cw5.Endpoints;
//
// public static class AnimalEndpoints
// {
//     public static void MapAnimalEndpoints(this WebApplication app)
//     {
//         app.MapGet("/animals", () =>
//         {
//             var animals = StaticData._animals;
//
//             return Results.Ok(animals);
//         });
//
//
//         app.MapGet("/animals/{id}", (int id) =>
//         {
//             Results.Ok(id);
//         });
//
//
//         app.MapPost("/animals", (Animal animal) =>
//         {
//             return Results.Created("",animal);
//
//         });
//     }
// }