namespace Patinhas.Backend.Application.UseCases.Ongs.AddPhoto;
public record AddPhotoPayload
{
    public int IdAnimal {get;set;}
    public string Url {get;set;}
}