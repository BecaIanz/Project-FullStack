using Patinhas.Application.IServices;
using Patinhas.Backend.Domain.Entities;

namespace Patinhas.Backend.Application.UseCases.User.LikeAnimal;

public class LikeAnimalUseCase(IUserService userService, IAnimalService animalService)
{
    public async Task<Result<LikeAnimalResponse>> Do(LikeAnimalPayload payload)
    {
        var combination = new Combinacao
        {
            Aceito = false,
            Gostou = true,
            UsuarioId = payload.UserId,
            Usuario = await userService.FindById(payload.UserId),
            AnimalId = payload.AnimalId,
            Animal = await animalService.FindById(payload.AnimalId)
        };
        // Create Like Entity!
        return Result<LikeAnimalResponse>.Success(new LikeAnimalResponse());
    }
}