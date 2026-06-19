namespace Patinhas.Application.IServices;
using Patinhas.Backend.Domain.Entities;

public interface IAnimalService
{
    Task<Animal?> FindById(int id);
    Task<List<Animal>> GetAll();
    Task<List<AnimalFoto>> GetPhotos(int animalId);

    // CRUD
    Task<int> CreateAnimal(Animal animal);
    Task<bool> DeleteAnimal(Animal animal);

    Task<bool> UpdateAnimal(int id, Animal animal);

    Task<bool> AddAnimalPhoto(int animalId, string photoUrl);

    Task<bool> RemoveAnimalPhoto(int animalId, string photoUrl);
}