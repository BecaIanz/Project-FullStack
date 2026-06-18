namespace Patinhas.Backend.Application.UseCases.Animals.AddPhoto;

public record AddPhotoPayload
{
    public string Url {get;set;}
    public int AnimalId {get;set;}

}
