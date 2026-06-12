namespace Patinhas.Backend.Application.UseCases.User.LikeAnimal;

public record LikeAnimalPayload
{
    public int UserId { get; set; }
    public int AnimalId { get; set; }
    public DateTime CreatedAt { get; set; }
}