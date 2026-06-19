using Patinhas.Application.IServices;
using Patinhas.Backend.Domain.Entities;

namespace Patinhas.Backend.Application.UseCases.Combinations.LikeAnimal;

public record LikeAnimalUseCase(
    ICombinationService ICombinationService,
    IUserService IUserService,
    IAnimalService IAnimalService)
{
    public async Task<Result<LikeAnimalResponse>> Do(
        LikeAnimalPayload payload)
    {
        try
        {
            var user = await IUserService.FindById(payload.UsuarioId);

            if (user is null)
                return Result<LikeAnimalResponse>
                    .Fail("Usuário não encontrado");

            var animal = await IAnimalService.FindById(payload.AnimalId);

            if (animal is null)
                return Result<LikeAnimalResponse>
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
                        Gostou = true,
                        Aceito = false
                    });
            }
            else
            {
                combination.Gostou = true;

                await ICombinationService
                    .UpdateCombination(combination);
            }

            return Result<LikeAnimalResponse>
                .Success(new LikeAnimalResponse());
        }
        catch (Exception ex)
        {
            return Result<LikeAnimalResponse>
                .Fail(ex.Message);
        }
    }
}