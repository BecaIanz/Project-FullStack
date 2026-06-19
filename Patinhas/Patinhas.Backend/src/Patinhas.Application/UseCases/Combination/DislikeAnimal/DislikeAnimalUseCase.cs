using Patinhas.Application.IServices;
using Patinhas.Backend.Domain.Entities;

namespace Patinhas.Backend.Application.UseCases.Combinations.DislikeAnimal;

public record DislikeAnimalUseCase(
    ICombinationService ICombinationService,
    IUserService IUserService,
    IAnimalService IAnimalService)
{
    public async Task<Result<DislikeAnimalResponse>> Do(
        DislikeAnimalPayload payload)
    {
        try
        {
            var user = await IUserService.FindById(payload.UsuarioId);

            if (user is null)
                return Result<DislikeAnimalResponse>
                    .Fail("Usuário não encontrado");

            var animal = await IAnimalService.FindById(payload.AnimalId);

            if (animal is null)
                return Result<DislikeAnimalResponse>
                    .Fail("Animal não encontrado");

            var combination =
                await ICombinationService.FindByUserAndAnimal(
                    payload.UsuarioId,
                    payload.AnimalId);

            if (combination is null)
            {
                await ICombinationService.CreateCombination(
                    new Combinacao
                    {
                        Usuario = user,
                        UsuarioId = user.Id,
                        Animal = animal,
                        AnimalId = animal.Id,
                        Gostou = false,
                        Aceito = false
                    });
            }
            else
            {
                combination.Gostou = false;

                await ICombinationService
                    .UpdateCombination(combination);
            }

            return Result<DislikeAnimalResponse>
                .Success(new DislikeAnimalResponse());
        }
        catch (Exception ex)
        {
            return Result<DislikeAnimalResponse>
                .Fail(ex.Message);
        }
    }
}