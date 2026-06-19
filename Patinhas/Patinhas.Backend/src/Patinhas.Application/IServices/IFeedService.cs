using Patinhas.Backend.Domain.Entities;

public interface IFeedService
{
    Task<List<Animal>> GetFeed(int usuarioId);

    Task<Animal?> GetNextAnimal(int usuarioId);
}