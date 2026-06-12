using Patinhas.Backend.Domain.Entities;

namespace Patinhas.Backend.Application.UseCases.Ong.AproveProfile;

public record AproveProfilePayload
{
    public required int CombinationID { get; set; }
    public bool Answer {get; set;}
};