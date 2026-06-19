using Patinhas.Application.IServices;
using Patinhas.Backend.Domain.Entities;

namespace Patinhas.Backend.Application.UseCases.User.AddPhoto;

public record AddPhotoUseCase(IUserService IUserService)
{
    public async Task<Result<AddPhotoResponse>> Do(AddPhotoPayload payload)
    {
        try
        {
            // await IUserService.(payload.UserId,payload.Url);
            return Result<AddPhotoResponse>.Success(new AddPhotoResponse());
        }
        catch(Exception ex)
        {
            return Result<AddPhotoResponse>.Fail(ex.Message);
        
        }
    }
}