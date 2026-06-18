using Microsoft.EntityFrameworkCore;
using Patinhas.Application.IServices;
using Patinhas.Backend.Domain.Entities;
using Patinhas.Infrastructure.Context;

public class FeedService(Context ctx) : IFeedService
{
    public void DeleteById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Animal>> GetFeed()
    {
        return ctx.Animais.AsNoTracking().Take(10).ToListAsync();
    }
}