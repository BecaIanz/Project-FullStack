using Patinhas.Application.IServices;
using Patinhas.Backend.Domain.Entities;

namespace Patinhas.Backend.Application.UseCases.Ongs.FindOngById;

public record FindOngByIdUseCase(
    IOngService IOngService)
{
    public async Task<Result<FindOngByIdResponse>> Do(
        FindOngByIdPayload payload)
    {
        try
        {
            var ong = await IOngService
                .FindById(payload.OngId);

            if (ong is null)
            {
                return Result<FindOngByIdResponse>
                    .Fail("ONG não encontrada");
            }

            var dto = new OngDto(
                ong.Id,
                ong.Nome
            );

            return Result<FindOngByIdResponse>
                .Success(
                    new FindOngByIdResponse(dto)
                );
        }
        catch (Exception ex)
        {
            return Result<FindOngByIdResponse>
                .Fail(ex.Message);
        }
    }
}