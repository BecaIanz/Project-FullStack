namespace Patinhas.Backend.Domain.DTOs.AnimalDTOs;
public record UpdateAnimalDTO
{
    public string  Nome { get; set; }
    public string  Tipo { get; set; }
    public string  Raca { get; set; }
    
}