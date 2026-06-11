namespace Patinhas.Application.IServices;
using Patinhas.Domain.Entities;

public interface IUserService
{
    Task<int> CreateUser(Usuario usuario);
    Task<Boolean> DeleteUser(Usuario usuario);
    Task<Usuario> FindByName(String name);
    Task<List<Usuario>> GetUsers(); // Filters?
    
}