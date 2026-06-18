using Patinhas.Application.IServices;
using Patinhas.Backend.Domain.Entities;

namespace Patinhas.Backend.Application.UseCases.Animals.UpdateAnimal;

public class UpdateAnimalUseCase(IAnimalService IAnimalService)
{
    public async Task<Result<UpdateAnimalResponse>> Do(UpdateAnimalPayload Payload)
    {
        try
        {
            var OldAnimal = await IAnimalService.FindById(Payload.Id);

            string nome = OldAnimal.Nome;
            string tipo = OldAnimal.Tipo;
            string raca = OldAnimal.Raca;

            if (Payload.Nome != null)
                nome = Payload.Nome;
            if (Payload.Tipo != null)
                tipo = Payload.Tipo;
            if (Payload.Raca != null)
                raca = Payload.Raca;
            
            var animal = new Animal
            {  
                Nome = nome,
                Tipo = tipo,
                Raca = raca,
                Ong = OldAnimal.Ong,
                OngId = OldAnimal.OngId
        
            };
            await IAnimalService.UpdateAnimal(Payload.Id,animal);

            return Result<UpdateAnimalResponse>.Success(new UpdateAnimalResponse());
        }
        catch (Exception ex){

            return Result<UpdateAnimalResponse>.Fail(ex.Message);
          }
    }
}