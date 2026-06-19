using Microsoft.EntityFrameworkCore;
using Patinhas.Backend.Domain.Entities;
using Patinhas.Infrastructure.Context;

namespace Patinhas.Infrastructure.Services;

public class CombinationService(PatinhasContext ctx) : ICombinationService
{
    public async Task<Combinacao?> FindById(int id)
    {
        return await ctx.Combinacoes
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<Combinacao?> FindByUserAndAnimal(
        int usuarioId,
        int animalId)
    {
        return await ctx.Combinacoes
            .FirstOrDefaultAsync(c =>
                c.UsuarioId == usuarioId &&
                c.AnimalId == animalId);
    }

    public async Task<int> CreateCombination(
        Combinacao combination)
    {
        ctx.Combinacoes.Add(combination);

        await ctx.SaveChangesAsync();

        return combination.Id;
    }

    public async Task<bool> UpdateCombination(
        Combinacao combination)
    {
        ctx.Combinacoes.Update(combination);

        return await ctx.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteCombination(
        Combinacao combination)
    {
        ctx.Combinacoes.Remove(combination);

        return await ctx.SaveChangesAsync() > 0;
    }
     public async Task<bool> ConfirmationCombinacao(Combinacao combination)
    {
        combination.Aceito = true;
        return await ctx.SaveChangesAsync() > 0;
    }
}