namespace Patinhas.Application.IServices;
using Patinhas.Backend.Domain.Entities;

public interface ICombinationService
{
    Task<Combinacao> FindById(int id);
    Task<int> CreateCombination(Combinacao combinacao);
    Task<Boolean> DeleteCombination(Combinacao combinacao);
}