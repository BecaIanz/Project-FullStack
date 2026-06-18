using Patinhas.Application.IServices;
using Patinhas.Backend.Domain.Entities;

namespace Patinhas.Backend.Application.UseCases.Ongs.AproveProfile;

public class AproveProfileUseCase(IOngService ongService)
{
    public async Task<Result<AproveProfileResponse>> Do(AproveProfilePayload payload)
    {
        if (payload.Answer)
        {
            
            // var combination = 
            // combination.Aceito = true;
            // algo?
        }
        // deletar combinacao

        return Result<AproveProfileResponse>.Success(new AproveProfileResponse());
    }
}