namespace Patinhas.Infrastructure.Services;

using Patinhas.Infrastructure.Context;
using Patinhas.Application.IServices;
using Microsoft.EntityFrameworkCore;
using Patinhas.Backend.Domain.Entities;

public class UserService(PatinhasContext ctx) : IUserService
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

    // public async Task<bool> LikeAnimal(int animalId)
    // {
    //     var animal = await ctx.Animais.FirstOrDefaultAsync(a => a.Id == animalId);
    //     var likeanimal = LikeAnimal
    //     {
            
    //     }
    // }

    // public Task<bool> DislikeAnimal(int animalId)
    // {
    //     throw new NotImplementedException();
    // }

    public async Task<Usuario> FindById(int id)
    {
        var user = await ctx.Usuarios.FirstOrDefaultAsync(u => u.Id == id);
        return user;
    }

    public async Task UpdateUser(Usuario usuario)
    {
        ctx.Usuarios.Update(usuario);
        await ctx.SaveChangesAsync();
    }

    public async Task<bool> AddUserPhoto(int id, string url)
    {
        var user = await ctx.Usuarios.FirstOrDefaultAsync(u => u.Id == id);
        
        if (user == null)
            return false;
        
        var newPhoto = new UsuarioFoto()
        {
            Url = url,
            Usuario = user,
            UsuarioId = id
        };

        ctx.UsuarioFotos.Add(newPhoto);
        await ctx.SaveChangesAsync();
        return true;
    }

}

