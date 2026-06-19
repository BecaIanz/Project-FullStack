using Patinhas.Application.IServices;
using Patinhas.Backend.Domain.Entities;

namespace Patinhas.Backend.Application.UseCases.User.UpdateUser;

public class UpdateUserUseCase(IUserService IuserService)
{
public async Task<Result<UpdateUserResponse>> Do(UpdateUserPayload payload)
{
    try
    {
        var oldUser = await IuserService.FindById(payload.Id);

        if (oldUser == null)
            return Result<UpdateUserResponse>.Fail("Usuário não encontrado");

        string nome = oldUser.Nome;
        string descricao = oldUser.Descricao;

        if (payload.Nome != null)
            nome = payload.Nome;

        if (payload.Descricao != null)
            descricao = payload.Descricao;

        var newUser = new Usuario
        {
            Id = payload.Id,
            Nome = nome,
            Descricao = descricao
        };

        await IuserService.UpdateUser(newUser);

        return Result<UpdateUserResponse>.Success(new UpdateUserResponse());
    }
    catch (Exception ex)
    {
        return Result<UpdateUserResponse>.Fail(ex.Message);
    }
}
}