namespace Patinhas.Backend.Application.UseCases.User.AddPhoto;

public record AddPhotoPayload
{
    public int UsuarioId {get;set;}
    public string Url {get;set;}
}