using Patinhas.Application.IServices;
using Patinhas.Backend.Domain.Entities;
namespace Patinhas.Backend.Application.UseCases.GetFeed;

public record AnimalDTO{
    
}
public class GetFeedService(IFeedService feedService)
{
    public async Task<Result<GetFeedResponse>> Do(GetFeedPayload payload)
    {
        var feed = await feedService.GetFeed();
        return Result<GetFeedResponse>.Success(new GetFeedResponse(
           
        ));
    }
}