namespace Patinhas.Backend.Application.UseCases.Animals.CreateAnimal;

public record CreateAnimalPayload
{
    public string  Nome { get; set; }
    public string  Tipo { get; set; }
    public string  Raca { get; set; }
    public int  OngId { get; set; }
    
}