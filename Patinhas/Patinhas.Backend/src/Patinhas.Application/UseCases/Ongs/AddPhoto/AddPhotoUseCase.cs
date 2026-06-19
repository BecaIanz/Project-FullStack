
using Patinhas.Application.IServices;
using Patinhas.Backend.Application.UseCases.Animals.AddPhoto;
using Patinhas.Backend.Domain.Entities;

namespace Patinhas.Backend.Application.UseCases.ongs.AddPhoto;

public record AddPhotoUseCase(IOngService IOngService)
{
    public async Task<Result<AddPhotoResponse>> Do(AddPhotoPayload payload)
    {
        try
        {
            // await IOngService.(payload.OngId,payload.Url);
            return Result<AddPhotoResponse>.Success(new AddPhotoResponse());
        }
        catch(Exception ex)
        {
            return Result<AddPhotoResponse>.Fail(ex.Message);
        
        }
    }
}