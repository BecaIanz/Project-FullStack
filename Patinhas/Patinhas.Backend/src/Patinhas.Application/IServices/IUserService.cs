namespace Patinhas.Application.IServices;
using Patinhas.Backend.Domain.Entities;

public interface IUserService
{
    Task<Usuario> FindById(int id);
    Task<int> CreateUser(Usuario usuario);
    Task<Boolean> DeleteUser(Usuario usuario);
    Task<Usuario> FindByName(String name);
    Task<Boolean> UpdateUser(int id,Usuario usuario);

    Task<List<Usuario>> GetUsers(); // Filters?
    Task<Boolean> LikeAnimal(int animalId);
    Task<Boolean> DislikeAnimal(int animalId);
}