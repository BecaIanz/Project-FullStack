using Patinhas.Application.IServices;
using Patinhas.Backend.Application.UseCases.Animals;
using Patinhas.Backend.Domain.DTOs;
using Patinhas.Backend.Domain.Entities;

namespace Patinhas.Backend.Application.UseCases.Animals.GetAnimals;

public record GetAnimalsUseCase(
    IAnimalService IAnimalService)
{
    public async Task<Result<GetAnimalsResponse>> Do(
        GetAnimalsPayload payload)
    {
        try
        {
            var animals = await IAnimalService.GetAll();

            var animalDtos = animals
                .Select(animal => new AnimalDto(
                    animal.Id,
                    animal.Nome,
                    animal.Tipo,
                    animal.Raca
                ))
                .ToList();

            return Result<GetAnimalsResponse>
                .Success(
                    new GetAnimalsResponse(
                        animalDtos
                    )
                );
        }
        catch (Exception ex)
        {
            return Result<GetAnimalsResponse>
                .Fail(ex.Message);
        }
    }
}