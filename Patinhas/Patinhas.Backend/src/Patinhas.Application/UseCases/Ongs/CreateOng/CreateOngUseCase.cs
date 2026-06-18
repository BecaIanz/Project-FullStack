using Patinhas.Application.IServices;
using Patinhas.Backend.Domain.Entities;
namespace Patinhas.Backend.Application.UseCases.Ongs.CreateOng;

public class CreateOngUseCase(IOngService IOngService)
{
    public async Task<Result<CreateOngResponse>> Do(CreateOngPayload payload)
    {
        var ong = new Ong
        {
            Nome = payload.Nome,
            Animais = []
        };
        try
        {
            await IOngService.CreateOngAsync(ong);
            return Result<CreateOngResponse>.Success(new CreateOngResponse());
        }
        catch (Exception ex){

            return Result<CreateOngResponse>.Fail(ex.Message);
            
        }
    }
}