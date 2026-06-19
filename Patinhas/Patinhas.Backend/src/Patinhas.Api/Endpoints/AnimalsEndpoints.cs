using Patinhas.Backend.Application.UseCases.GetFeed;

namespace Patinhas.Backend.Api.Endpoint;

using Patinhas.Application.IServices;
using Patinhas.Backend.Application.UseCases.Animals.AddPhoto;
using Patinhas.Backend.Application.UseCases.Animals.CreateAnimal;
using Patinhas.Backend.Application.UseCases.Animals.DeleteAnimal;
using Patinhas.Backend.Application.UseCases.Animals.UpdateAnimal;
using Patinhas.Backend.Domain.DTOs;

public static class AnimalEndpoint
{
    public static void ConfigureAnimalEndipoints(this WebApplication app)
    {
    app.MapGet("Animal/{Id}", (int id)=>
    {
        return Results.Ok($"Animal {id}");
    }
    );
    app.MapGet("Animais",(GetFeedPayload payload)=>{
           return Results.Ok<GetFeedResponse>;
        });
    app.MapPost("Create",(CreateAnimalPayload payload)=>{
        return Results.Created($"/Animal", payload);
    });
    app.MapPut("Update/{id}",(UpdateAnimalPayload payload)=>{
        return Results.Ok<UpdateAnimalResponse>;
    });
    app.MapDelete("Delete/{id}",(DeleteAnimalPayload payload)=>{
        return Results.Ok<DeleteAnimalResponse>;
    });
    app.MapPut("UpdatePhoto/{id}",(AddPhotoPayload payload)=>{
        return Results.Ok<AddPhotoResponse>;
    });


    
}
}