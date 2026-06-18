using Patinhas.Application.IServices;
using Patinhas.Backend.Domain.Entities;

namespace Patinhas.Backend.Application.UseCases.Ongs.UpdateOng;

public class UpdateOngUseCase(IOngService IOngService)
{
    public async Task<Result<UpdateOngResponse>> Do(UpdateOngPayload payload)
    {
        try
        {
            var Oldong = await IOngService.FindById(payload.Id);

            string nome = Oldong.Nome;

            if (payload.Nome != null)
                nome = payload.Nome;
            
            var ong = new Ong
            {
                Nome=nome
            };

            await IOngService.UpdateOngAsync(payload.Id,ong);

            return Result<UpdateOngResponse>.Success(new UpdateOngResponse());
        }
        catch (Exception ex){

            return Result<UpdateOngResponse>.Fail(ex.Message);
          }
    }
}