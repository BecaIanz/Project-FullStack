using Patinhas.Backend.Domain.Entities;

public interface ICombinationService
{
    Task<Combinacao?> FindById(int id);

    Task<int> CreateCombination(Combinacao combinacao);

    Task<bool> DeleteCombination(Combinacao combinacao);
    Task<bool> ConfirmationCombinacao(Combinacao combinacao);
    
}