using Patinhas.Application.IServices;
using Patinhas.Backend.Domain.Entities;

namespace Patinhas.Backend.Application.UseCases.User.CreateUser;

public class CreateUserUseCase(IUserService IuserService)
{
    public async Task<Result<CreateUserResponse>> Do(CreateUserPayload payload)
    {
        var User = new Usuario
        {
            Nome = payload.Nome,
            Descricao = payload.Descricao,
            Fotos = [],
            Combinacoes = []
           
        };
        try
        {
            await IuserService.CreateUser(User);
            return Result<CreateUserResponse>.Success(new CreateUserResponse());
        }
        catch (Exception ex){

            return Result<CreateUserResponse>.Fail(ex.Message);
            
        }
    }
}