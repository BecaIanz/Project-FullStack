using Patinhas.Backend.Patinhas.Application.Services;

public class UserService() : IUserService
{
    public Task<Guid> CreateUser(Usuario usuario)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteUser(Usuario usuario)
    {
        throw new NotImplementedException();
    }

    public Task<Usuario> FindByName(string name)
    {
        throw new NotImplementedException();
    }

    public Task<List<Usuario>> GetUsers()
    {
        throw new NotImplementedException();
    }
}