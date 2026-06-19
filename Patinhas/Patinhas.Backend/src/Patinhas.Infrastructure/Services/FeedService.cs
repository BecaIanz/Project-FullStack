using Microsoft.EntityFrameworkCore;
using Patinhas.Application.IServices;
using Patinhas.Backend.Domain.Entities;
using Patinhas.Infrastructure.Context;

public class FeedService(PatinhasContext ctx) : IFeedService
{
    public async Task<List<Animal>> GetFeed(int usuarioId)
    {
        var animalIdsJaVistos = await ctx.Combinacoes
            .Where(c => c.UsuarioId == usuarioId)
            .Select(c => c.AnimalId)
            .ToListAsync();

        return await ctx.Animais
            .Include(a => a.Fotos)
            .Where(a => !animalIdsJaVistos.Contains(a.Id))
            .ToListAsync();
    }

    public async Task<Animal?> GetNextAnimal(int usuarioId)
    {
        var animalIdsJaVistos = await ctx.Combinacoes
            .Where(c => c.UsuarioId == usuarioId)
            .Select(c => c.AnimalId)
            .ToListAsync();

        return await ctx.Animais
            .Include(a => a.Fotos)
            .Where(a => !animalIdsJaVistos.Contains(a.Id))
            .FirstOrDefaultAsync();
    }
}