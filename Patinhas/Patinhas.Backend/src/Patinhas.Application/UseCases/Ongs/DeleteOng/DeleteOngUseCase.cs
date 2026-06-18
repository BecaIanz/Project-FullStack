using Patinhas.Application.IServices;
namespace Patinhas.Backend.Application.UseCases.Ongs.DeleteOng;
using Patinhas.Backend.Domain.Entities;

public class DeleteOngUseCase(IOngService Iong)
{
    public async Task<Result<DeleteOngResponse>> Do(DeleteOngPayload payload)
    {
        
        try
        {
            var ong = await Iong.FindById(payload.Id);
            await Iong.DeleteOngAsync(ong);
        
            return Result<DeleteOngResponse>.Success(new DeleteOngResponse());
        }
        catch (Exception ex){

            return Result<DeleteOngResponse>.Fail(ex.Message);
            
        }
    }
}