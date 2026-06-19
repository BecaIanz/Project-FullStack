using Patinhas.Application.IServices;
using Patinhas.Backend.Domain.DTOs;
using Patinhas.Backend.Domain.Entities;

namespace Patinhas.Backend.Application.UseCases.Users.FindUserById;

public record FindUserByIdUseCase(
    IUserService IUserService)
{
    public async Task<Result<FindUserByIdResponse>> Do(
        FindUserByIdPayload payload)
    {
        try
        {
            var user = await IUserService
                .FindById(payload.UserId);

            if (user is null)
            {
                return Result<FindUserByIdResponse>
                    .Fail("Usuário não encontrado");
            }

            var dto = new UserDto(
                user.Id,
                user.Nome
            );

            return Result<FindUserByIdResponse>
                .Success(
                    new FindUserByIdResponse(dto)
                );
        }
        catch (Exception ex)
        {
            return Result<FindUserByIdResponse>
                .Fail(ex.Message);
        }
    }
}