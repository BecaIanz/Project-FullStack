using Patinhas.Backend.Application.UseCases.Animals;
using Patinhas.Backend.Domain.DTOs;

namespace Patinhas.Backend.Application.UseCases.Animals.FindAnimalById;

public record FindAnimalByIdResponse(
    AnimalDto Animal
);