using Microsoft.EntityFrameworkCore;
using Patinhas.Application.IServices;
using Patinhas.Backend.Domain.Entities;
using Patinhas.Infrastructure.Context;

public class AnimalService(Context ctx) : IAnimalService
{

    public async Task<List<Animal>> GetAll()
    {
        return await ctx.Animais.ToListAsync();
    }
    public async Task<int> CreateAnimal(Animal animal)
    {
        ctx.Animais.Add(animal);

        await ctx.SaveChangesAsync();

        return animal.Id;
    }

    public async Task<bool> DeleteAnimal(Animal animal)
    {
        ctx.Animais.Remove(animal);

        return await ctx.SaveChangesAsync() > 0;
    }

    public async Task<bool> UpdateAnimal(int id, Animal animal)
    {
        var existingAnimal = await ctx.Animais
                .FirstOrDefaultAsync(a => a.Id == id);

        if (existingAnimal is null)
            return false;

        existingAnimal.Nome = animal.Nome;
        existingAnimal.Raca = animal.Raca;
        existingAnimal.Tipo = animal.Tipo;

        return await ctx.SaveChangesAsync() > 0;
    }

    public async Task<bool> AddAnimalPhoto(int animalId, string photoUrl)
    {
        var animalExists = await ctx.Animais
            .AnyAsync(a => a.Id == animalId);

        if (!animalExists)
            return false;

        var foto = new AnimalFoto
        {
            AnimalId = animalId,
            Url = photoUrl
        };

        ctx.AnimalFotos.Add(foto);

        return await ctx.SaveChangesAsync() > 0;
    }

    public async Task<bool> RemoveAnimalPhoto(int animalId, string photoUrl)
    {
        var photo = await ctx.AnimalFotos
            .FirstOrDefaultAsync(p =>
                p.AnimalId == animalId &&
                p.Url == photoUrl);

        if (photo is null)
            return false;

        ctx.AnimalFotos.Remove(photo);

        return await ctx.SaveChangesAsync() > 0;
    }

    public async Task<Animal> FindById(int id)
    {
        return await ctx.Animais
            .Include(a => a.Fotos)
            .FirstOrDefaultAsync(a => a.Id == id);
    }
}