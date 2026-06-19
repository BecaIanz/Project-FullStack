using Patinhas.Application.IServices;
using Patinhas.Backend.Domain.Entities;

namespace Patinhas.Backend.Application.UseCases.Animals.AddPhoto;

public record AddPhotoUseCase(IAnimalService IAnimalService)
{
    public async Task<Result<AddPhotoResponse>> Do(AddPhotoPayload payload)
    {
        try
        {
            await IAnimalService.AddAnimalPhoto(payload.AnimalId,payload.Url);
            return Result<AddPhotoResponse>.Success(new AddPhotoResponse());
        }
        catch(Exception ex)
        {
            return Result<AddPhotoResponse>.Fail(ex.Message);
        
        }
    }
}