using Patinhas.Application.IServices;
using Patinhas.Backend.Domain.Entities;

namespace Patinhas.Backend.Application.UseCases.Animals.UpdateAnimal;

public class UpdateAnimalUseCase(IAnimalService IAnimalService)
{
    public async Task<Result<UpdateAnimalResponse>> Do(UpdateAnimalPayload payload)
    {
        try
        {
            var OldAnimal = await IAnimalService.FindById(payload.Id);

            string nome = OldAnimal.Nome;

            if (payload.Nome != null)
                nome = payload.Nome;
            
            var Animal = new Animal
            {
                Nome=nome
            };

            await IAnimalService.UpdateAnimal(payload.Id,Animal);

            return Result<UpdateAnimalResponse>.Success(new UpdateAnimalResponse());
        }
        catch (Exception ex){

            return Result<UpdateAnimalResponse>.Fail(ex.Message);
          }
    }
}