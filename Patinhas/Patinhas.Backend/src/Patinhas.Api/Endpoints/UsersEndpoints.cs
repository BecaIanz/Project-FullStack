namespace Patinhas.Backend.Api.Endpoint;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using  Patinhas.Backend.Application.UseCases.User.CreateUser;
using Patinhas.Backend.Application.UseCases.User.UpdateUser;
using Patinhas.Backend.Application.UseCases.User.AddPhoto;
using Patinhas.Backend.Application.UseCases.User.DeleteUser;

public static class UserEndpoints
{
    public static void ConfigureUserEndpoints(this WebApplication app)
    {
        app.MapGet("user/{id}",(int id) =>
        {
            return Results.Ok($"Usuário {id}");
        });
        app.MapPost("Create", (CreateUserPayload payload) =>
        {
            return Results.Created($"/user", payload);
        });
        app.MapPut("Update/{id}",(UpdateUserPayload payload)=>{
             return Results.Ok<UpdateUserResponse>;
        });
        app.MapDelete("Delete/{id}",(DeleteUserPayload payload)=>{
            return Results.Ok<DeleteUserResponse>;
        });
         app.MapPut("UpdatePhoto/{id}",(AddPhotoPayload payload)=>{
            return Results.Ok<AddPhotoResponse>;
         });
    }
}