namespace Patinhas.Application.IServices;

using System.Runtime.CompilerServices;
using Patinhas.Backend.Domain.Entities;

public interface IUserService
{
    Task<Usuario> FindById(int id);
    Task<int> CreateUser(Usuario usuario);

    Task<Boolean> AddUserPhoto (int id, string url);
    Task<Boolean> DeleteUser(Usuario usuario);
    Task<Usuario> FindByName(String name);
    Task UpdateUser(Usuario usuario);

    Task<List<Usuario>> GetUsers(); // Filters?
    // Task<Boolean> LikeAnimal(int animalId);
    // Task<Boolean> DislikeAnimal(int animalId);
}