namespace Patinhas.Application.IServices;

using Patinhas.Backend.Domain.Entities;

public interface IOngService
{
    Task<Ong> FindById(int id);
    Task<int> CreateOngAsync(Ong ong);
    Task<bool> DeleteOngAsync(Ong ong);
    Task<bool> UpdateOngAsync(Ong ong);
    Task<Ong?> FindByNameAsync(string name);
    Task<List<Ong>> GetOngsAsync();
    Task UpdateOngAsync(int id, Ong ong);
}