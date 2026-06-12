namespace Patinhas.Application.IServices;

using Patinhas.Domain.Entities;

public interface IAnimalService
{
    Task<int> CreateAnimal(Animal animal);

    Task<bool> DeleteAnimal(Animal animal);

    Task<bool> UpdateAnimal(Animal animal);

    Task<bool> AddAnimalPhoto(int animalId, string photoUrl);

    Task<bool> RemoveAnimalPhoto(int animalId, string photoUrl);
}