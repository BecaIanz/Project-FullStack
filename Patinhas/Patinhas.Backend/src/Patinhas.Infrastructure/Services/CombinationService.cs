using Patinhas.Application.IServices;
using Patinhas.Backend.Domain.Entities;
using Patinhas.Infrastructure.Context;

namespace Patinhas.Infrastructure.Services;

public class CombinationService(Context ctx) : ICombinationService
{
    public Task<int> CreateCombination(Combinacao combinacao)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteCombination(Combinacao combinacao)
    {
        throw new NotImplementedException();
    }

    public Task<Combinacao> FindById(int id)
    {
        throw new NotImplementedException();
    }
}