namespace Patinhas.Application.IServices;
using Patinhas.Backend.Domain.Entities;
public interface IFeedService
{
    Task<List<Animal>> GetFeed(Usuario usuario);
}