namespace Patinhas.Backend.Api.Controller;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using  Patinhas.Backend.Application.UseCases.User.CreateUser;
public static class UserEndpoints
{
    public static void ConfigureUserEndpoints(this WebApplication app)
    {
        app.MapGet("user/{id}",(string id) =>
        {
            return Results.Ok($"Usuário {id}");
        });
        app.MapPost("Create", (CreateUserPayload payload) =>
        {
            return Results.Created($"/user", payload);
        });
    }
}