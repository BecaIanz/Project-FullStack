using Patinhas.Application.IServices;
using Patinhas.Backend.Domain.Entities;
namespace Patinhas.Backend.Application.UseCases.GetFeed;

public class GetFeedService(IFeedService feedService)
{
    public async Task<Result<GetFeedResponse>> Do(GetFeedPayload payload)
    {
        // feedService.GetFeed();
        return Result<GetFeedResponse>.Success(new GetFeedResponse());
    }
}