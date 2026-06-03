using Microsoft.EntityFrameworkCore;

public static class AnimalClassMap
{
    public static void ConfigureAnimalClassMap(this ModelBuilder modelBuilder)
    => modelBuilder.Entity<Animal>(builder =>
    {
        builder.HasKey(animal => animal.Id);
        builder.Property(animal => animal.Id)
            .HasColumnName("id");
        builder.ToTable("tb_animal");


    //================PROPERTIES================
        builder.Property(animal => animal.Nome)
            .HasColumnName("nome")
            .IsRequired();
        builder.Property(animal => animal.Tipo)
            .HasColumnName("tipo")
            .IsRequired();
        builder.Property(animal => animal.Raca)
            .HasColumnName("raca")
            .IsRequired();

    //================MY-RELATIONS================
        builder.Property(animal => animal.OngId)
            .HasColumnName("ong_id")
            .IsRequired();
        builder.HasOne(animal => animal.Ong)
            .WithMany(ong => ong.Animais)
            .HasForeignKey(animal => animal.OngId);

    //================RELATIONS================
        builder.HasMany(animal => animal.Fotos)
            .WithOne(foto => foto.Animal)
            .HasForeignKey(foto => foto.AnimalId);

        builder.HasMany(animal => animal.Combinacoes)
            .WithOne(combinacao => combinacao.Animal)
            .HasForeignKey(combinacao => combinacao.AnimalId);
    });
}