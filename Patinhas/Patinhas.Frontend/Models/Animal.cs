namespace Frontend.Models;

public record Animal(
    string Name,
    List<string> Images,
    string Description,
    string Breed,
    string Age,
    string Sex,
    string? OngName
);