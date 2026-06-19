using Patinhas.Application.IServices;
using Patinhas.Backend.Domain.DTOs;
using Patinhas.Backend.Domain.Entities;

namespace Patinhas.Backend.Application.UseCases.Users.GetUsers;

public record GetUsersUseCase(IUserService IUserService)
{
    public async Task<Result<GetUsersResponse>> Do(
        GetUsersPayload payload)
    {
        try
        {
            var users = await IUserService.GetUsers();

            var userDtos = users
                .Select(u => new UserDto(
                    u.Id,
                    u.Nome
                ))
                .ToList();

            return Result<GetUsersResponse>.Success(
                new GetUsersResponse(userDtos)
            );
        }
        catch (Exception ex)
        {
            return Result<GetUsersResponse>.Fail(
                ex.Message
            );
        }
    }
}