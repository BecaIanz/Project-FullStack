using Patinhas.Backend.Domain.DTOs;

namespace Patinhas.Backend.Application.UseCases.Users.FindUserById;

public record FindUserByIdResponse(
    UserDto Usuario
);