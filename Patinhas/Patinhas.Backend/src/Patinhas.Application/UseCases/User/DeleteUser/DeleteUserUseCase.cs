using Patinhas.Application.IServices;
using Patinhas.Backend.Domain.Entities;

namespace Patinhas.Backend.Application.UseCases.User.DeleteUser;

public class DeleteUserUseCase(IUserService IuserService)
{
    public async Task<Result<DeleteUserResponse>> Do(DeleteUserPayload payload)
    {
        
        try
        {
            var userid = await IuserService.FindById(payload.Id);
            await IuserService.DeleteUser(userid);

            return Result<DeleteUserResponse>.Success(new DeleteUserResponse());
        }
        catch (Exception ex){

            return Result<DeleteUserResponse>.Fail(ex.Message);
            
        }
    }
}