using Patinhas.Application.IServices;
namespace Patinhas.Backend.Application.UseCases.Animals.DeleteAnimal;
using Patinhas.Backend.Domain.Entities;

public class DeleteAnimalUseCase(IAnimalService IAnimal)
{
    public async Task<Result<DeleteAnimalResponse>> Do(DeleteAnimalPayload payload)
    {
        
        try
        {
            var Animal = await IAnimal.FindById(payload.Id);
            await IAnimal.DeleteAnimal(Animal);
        
            return Result<DeleteAnimalResponse>.Success(new DeleteAnimalResponse());
        }
        catch (Exception ex){

            return Result<DeleteAnimalResponse>.Fail(ex.Message);
            
        }
    }
}