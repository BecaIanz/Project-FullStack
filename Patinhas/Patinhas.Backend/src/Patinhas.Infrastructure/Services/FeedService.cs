using Microsoft.EntityFrameworkCore;
using Patinhas.Application.IServices;
using Patinhas.Domain.Entities;
using Patinhas.Infrastructure.Context;

public class FeedService(Context ctx) : IFeedService
{
    public Task<List<Animal>> GetFeed(Usuario usuario)
    {
        return ctx.Animais.AsNoTracking().Take(10).ToListAsync();
    }
}