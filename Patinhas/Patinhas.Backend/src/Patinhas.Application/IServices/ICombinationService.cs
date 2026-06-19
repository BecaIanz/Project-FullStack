using Patinhas.Backend.Domain.Entities;

public interface ICombinationService
{
    Task<Combinacao?> FindById(int id);

    Task<Combinacao?> FindByUserAndAnimal(
        int usuarioId,
        int animalId);

    Task<int> CreateCombination(Combinacao combination);

    Task<bool> UpdateCombination(Combinacao combination);

    Task<bool> DeleteCombination(Combinacao combination);
}