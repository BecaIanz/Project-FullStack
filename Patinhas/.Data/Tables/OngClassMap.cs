using Microsoft.EntityFrameworkCore;

public static class OngClassMap
{
    public static void ConfigureOngClassMap(this ModelBuilder modelBuilder)
    => modelBuilder.Entity<Ong>(builder =>
    {
        builder.HasKey(ong => ong.Id);
        builder.Property(ong => ong.Id)
            .HasColumnName("id");
        builder.ToTable("tb_ong");
    //================PROPERTIES================
        builder.Property(ong => ong.Nome)
            .HasColumnName("nome")
            .IsRequired();

    //================RELATIONS================
        builder.HasMany(ong => ong.Animais)
            .WithOne(ong => ong.Ong)
            .HasForeignKey(animal => animal.OngId);
    });
}