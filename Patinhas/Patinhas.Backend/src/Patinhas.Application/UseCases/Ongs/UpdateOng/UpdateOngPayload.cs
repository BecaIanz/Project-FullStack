namespace Patinhas.Backend.Application.UseCases.Ongs.UpdateOng;

public record UpdateOngPayload
{
    public int  Id { get; set; }
    public string  Nome { get; set; }
}