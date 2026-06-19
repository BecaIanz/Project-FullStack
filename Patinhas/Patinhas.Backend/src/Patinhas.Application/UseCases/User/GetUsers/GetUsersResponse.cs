using Patinhas.Backend.Domain.DTOs;
using Patinhas.Backend.Domain.Entities;

namespace Patinhas.Backend.Application.UseCases.Users.GetUsers;

public record GetUsersResponse(
    List<UserDto> Usuarios
);