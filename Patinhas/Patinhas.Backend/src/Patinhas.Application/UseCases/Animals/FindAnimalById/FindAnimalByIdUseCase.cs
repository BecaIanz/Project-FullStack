using Patinhas.Application.IServices;
using Patinhas.Backend.Application.UseCases.Animals;
using Patinhas.Backend.Domain.DTOs;
using Patinhas.Backend.Domain.Entities;

namespace Patinhas.Backend.Application.UseCases.Animals.FindAnimalById;

public record FindAnimalByIdUseCase(
    IAnimalService IAnimalService)
{
    public async Task<Result<FindAnimalByIdResponse>> Do(
        FindAnimalByIdPayload payload)
    {
        try
        {
            var animal = await IAnimalService
                .FindById(payload.AnimalId);

            if (animal is null)
            {
                return Result<FindAnimalByIdResponse>
                    .Fail("Animal não encontrado");
            }

            var dto = new AnimalDto(
                animal.Id,
                animal.Nome,
                animal.Tipo,
                animal.Raca
            );

            return Result<FindAnimalByIdResponse>
                .Success(
                    new FindAnimalByIdResponse(dto)
                );
        }
        catch (Exception ex)
        {
            return Result<FindAnimalByIdResponse>
                .Fail(ex.Message);
        }
    }
}