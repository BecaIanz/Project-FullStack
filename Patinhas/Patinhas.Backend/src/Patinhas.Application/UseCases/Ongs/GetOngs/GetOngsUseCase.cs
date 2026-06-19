using Patinhas.Application.IServices;
using Patinhas.Backend.Application.UseCases.Ongs;
using Patinhas.Backend.Domain.Entities;

namespace Patinhas.Backend.Application.UseCases.Ongs.FindOngByName;

public record FindOngByNameUseCase(
    IOngService IOngService)
{
    public async Task<Result<FindOngByNameResponse>> Do(
        FindOngByNamePayload payload)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(payload.Nome))
            {
                return Result<FindOngByNameResponse>
                    .Fail("Nome inválido");
            }

            var ong = await IOngService
                .FindByNameAsync(payload.Nome);

            if (ong is null)
            {
                return Result<FindOngByNameResponse>
                    .Fail("ONG não encontrada");
            }

            var dto = new OngDto(
                ong.Id,
                ong.Nome
            );

            return Result<FindOngByNameResponse>
                .Success(
                    new FindOngByNameResponse(dto)
                );
        }
        catch (Exception ex)
        {
            return Result<FindOngByNameResponse>
                .Fail(ex.Message);
        }
    }
}