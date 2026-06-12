using Patinhas.Backend.Domain.Entities;

namespace Patinhas.Backend.Application.UseCases.GetFeed;

public record GetFeedResponse
{
    public List<Animal> ?Animals {get; set;}
}