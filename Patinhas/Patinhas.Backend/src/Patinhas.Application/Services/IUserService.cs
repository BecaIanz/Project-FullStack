namespace Patinhas.Backend.Patinhas.Application.Services;
public interface IUserService
{
    Task<Guid> CreateUser(Usuario usuario);
    Task<Boolean> DeleteUser(Usuario usuario);
    Task<Usuario> FindByName(String name);
    Task<List<Usuario>> GetUsers(); // Filters?
    
}