using Patinhas.Backend.Domain.Entities;

namespace Patinhas.Backend.Application.UseCases.Ongs.AproveProfile;

public record AproveProfilePayload
{
    public required int CombinationID { get; set; }
    public bool Answer {get; set;}
};