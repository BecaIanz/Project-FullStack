using Patinhas.Application.IServices;
using Patinhas.Backend.Domain.Entities;

namespace Patinhas.Backend.Application.UseCases.Ong.AproveProfile;

public class AproveProfileUseCase(IOngService ongService)
{
    public async Task<Result<AproveProfileResponse>> Do(AproveProfilePayload payload)
    {
        if (payload.Answer)
        {
            payload.Combination.Aceito = true;
            // algo?
        }
        // deletar combinacao

        return Result<AproveProfileResponse>.Success(new AproveProfileResponse());
    }
}