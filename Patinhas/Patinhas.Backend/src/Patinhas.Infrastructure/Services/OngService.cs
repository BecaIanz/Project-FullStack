using Microsoft.EntityFrameworkCore;
using Patinhas.Application.IServices;
using Patinhas.Backend.Domain.Entities;
using Patinhas.Infrastructure.Context;

public class OngService(PatinhasContext ctx) : IOngService
{
    public async Task<int> CreateOngAsync(Ong ong)
    {
        ctx.Ongs.Add(ong);

        await ctx.SaveChangesAsync();

        return ong.Id;
    }

    public async Task<bool> DeleteOngAsync(Ong ong)
    {
        ctx.Ongs.Remove(ong);

        return await ctx.SaveChangesAsync() > 0;
    }

    public async Task<bool> UpdateOngAsync(Ong ong)
    {
        ctx.Ongs.Update(ong);
        return await ctx.SaveChangesAsync() > 0;
    }

    public async Task<Ong?> FindByNameAsync(string name)
    {
        return await ctx.Ongs
            .AsNoTracking()
            .FirstOrDefaultAsync(o => o.Nome == name);
    }

    public async Task<Ong> FindById(int id)
    {
        var ong = await ctx.Ongs.FirstOrDefaultAsync(o => o.Id == id);
        return ong;
    }

    public async Task<List<Ong>> GetOngsAsync()
    {
        return await ctx.Ongs
            .AsNoTracking()
            .ToListAsync();
    }

   
}