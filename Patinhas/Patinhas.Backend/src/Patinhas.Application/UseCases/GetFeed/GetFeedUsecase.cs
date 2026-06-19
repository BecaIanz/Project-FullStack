using Patinhas.Application.IServices;
using Patinhas.Backend.Domain.Entities;
namespace Patinhas.Backend.Application.UseCases.GetFeed;

public record AnimalDTO{
    
}
public class GetFeedService(IFeedService feedService)
{
    public async Task<Result<GetFeedResponse>> Do(GetFeedPayload payload)
    {
        try
        {
            await feedService.GetFeed(payload.Usuarioid);
            return Result<GetFeedResponse>.Success(new GetFeedResponse());
        }
        catch(Exception ex)
        {
            return Result<GetFeedResponse>.Fail(ex.Message);
            
        }
    }
}