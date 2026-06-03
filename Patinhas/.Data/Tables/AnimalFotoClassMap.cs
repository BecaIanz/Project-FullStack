using Microsoft.EntityFrameworkCore;

public static class AnimalFotoClassMap
{
    public static void ConfigureAnimalFotoClassMap(this ModelBuilder modelBuilder)
    => modelBuilder.Entity<AnimalFoto>(builder =>
    {
        builder.HasKey(animalFoto => animalFoto.Id);
        builder.Property(animalFoto => animalFoto.Id)
            .HasColumnName("id");
        builder.ToTable("tb_animal_foto");
    
    //================PROPERTIES================
        builder.Property(animalFoto => animalFoto.Url)
            .HasColumnName("url")
            .IsRequired();

    //================MY-RELATIONS================
        builder.Property(animalFoto => animalFoto.AnimalId)
            .HasColumnName("animal_id")
            .IsRequired();
        builder.HasOne(animalFoto => animalFoto.Animal)
            .WithMany(animal => animal.Fotos)
            .HasForeignKey(animalFoto => animalFoto.AnimalId);
    });
}