namespace Patinhas.Backend.Application.UseCases.User.CreateUser;

public record CreateUserPayload
{
    public string  Nome { get; set; }
    public string  Descricao { get; set; }
}