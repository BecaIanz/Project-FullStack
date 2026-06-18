namespace Patinhas.Infrastructure.Services;

using Patinhas.Infrastructure.Context;
using Patinhas.Application.IServices;
using Microsoft.EntityFrameworkCore;
using Patinhas.Backend.Domain.Entities;

public class UserService(Context ctx) : IUserService
{
    public async Task<int> CreateUser(Usuario usuario)
    {
        ctx.Usuarios.Add(usuario);
        await ctx.SaveChangesAsync();
        return usuario.Id;
    }

    public async Task<bool> DeleteUser(Usuario usuario)
    {
        ctx.Usuarios.Remove(usuario);
        var rows = await ctx.SaveChangesAsync();
        return rows > 0;
    }

    public async Task<Usuario> FindByName(string name)
    {
        var profile = await ctx.Usuarios.FirstOrDefaultAsync(
            u => u.Nome == name
        );
        return profile;
    }

    public async Task<List<Usuario>> GetUsers()
    {
        return await ctx.Usuarios.AsNoTracking().ToListAsync();
    }

    public Task<bool> LikeAnimal(int animalId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DislikeAnimal(int animalId)
    {
        throw new NotImplementedException();
    }

    public Task<Usuario> FindById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateUser(int id, Usuario usuario)
    {
        throw new NotImplementedException();
    }
}