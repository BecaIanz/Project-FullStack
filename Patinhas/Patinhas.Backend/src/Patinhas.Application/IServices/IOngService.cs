namespace Patinhas.Application.IServices;

using Patinhas.Domain.Entities;

public interface IOngService
{
    Task<int> CreateOngAsync(Ong ong);
    Task<bool> DeleteOngAsync(Ong ong);
    Task<bool> UpdateOngAsync(Ong ong);
    Task<Ong?> FindByNameAsync(string name);
    Task<List<Ong>> GetOngsAsync();
}