
using Patinhas.Application.IServices;
using Patinhas.Backend.Domain.Entities;
namespace Patinhas.Backend.Application.UseCases.Animals.CreateAnimal;

public class CreateAnimalUseCase(IAnimalService IAnimalervice, IOngService IongService)
{
    public async Task<Result<CreateAnimalResponse>> Do(CreateAnimalPayload payload)
    {
        var ongs = await IongService.FindById(payload.OngId);
        var Animal = new Animal
        {
            Nome = payload.Nome,
            Tipo = payload.Tipo,
            Raca = payload.Raca,
            Ong = ongs,
            OngId = payload.OngId,
            Fotos = [],
            Combinacoes = []
        };
        try
        {
            await IAnimalervice.CreateAnimal(Animal);
            return Result<CreateAnimalResponse>.Success(new CreateAnimalResponse());
        }
        catch (Exception ex){

            return Result<CreateAnimalResponse>.Fail(ex.Message);
            
        }
    }
}

