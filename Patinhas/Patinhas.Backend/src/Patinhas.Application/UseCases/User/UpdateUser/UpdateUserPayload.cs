namespace Patinhas.Backend.Application.UseCases.User.UpdateUser;

public record UpdateUserPayload
{
    public int  Id { get; set; }
    public string  Nome { get; set; }
    public string  Descricao { get; set; }
}