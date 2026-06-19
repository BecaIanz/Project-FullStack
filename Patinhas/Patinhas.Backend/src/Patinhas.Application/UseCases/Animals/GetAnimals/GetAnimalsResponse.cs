using Patinhas.Backend.Application.UseCases.Animals;
using Patinhas.Backend.Domain.DTOs;

namespace Patinhas.Backend.Application.UseCases.Animals.GetAnimals;

public record GetAnimalsResponse(
    List<AnimalDto> Animals
);