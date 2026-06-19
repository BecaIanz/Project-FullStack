using Microsoft.EntityFrameworkCore;
using Patinhas.Backend.Domain.Entities;
using Patinhas.Infrastructure.Context;

namespace Patinhas.Infrastructure.Services;

public class CombinationService(PatinhasContext ctx) : ICombinationService
{
    public async Task<int> CreateCombination(Combinacao combinacao)
    {
        ctx.Combinacoes.Add(combinacao);

        await ctx.SaveChangesAsync();

        return combinacao.Id;
    }

    public async Task<bool> DeleteCombination(Combinacao combinacao)
    {
        ctx.Combinacoes.Remove(combinacao);

        return await ctx.SaveChangesAsync() > 0;
    }

    public async Task<Combinacao> FindById(int id)
    {
        return await ctx.Combinacoes
            .FirstOrDefaultAsync(c => c.Id == id);
    }
}