using Microsoft.EntityFrameworkCore;

public static class UsuarioClassMap
{
    public static void ConfigureUsuarioClassMap(this ModelBuilder modelBuilder)
    => modelBuilder.Entity<Usuario>(builder =>
    {
        builder.HasKey(usuario => usuario.Id);
        builder.Property(usuario => usuario.Id)
            .HasColumnName("id");
        builder.ToTable("tb_usuario");
        
    //================PROPERTIES================
        builder.Property(usuario => usuario.Nome)
            .HasColumnName("nome")
            .IsRequired();
        builder.Property(usuario => usuario.Descricao)
            .HasColumnName("descricao")
            .IsRequired();

    //================RELATIONS================
        builder.HasMany(usuario => usuario.Fotos)
            .WithOne(foto => foto.Usuario)
            .HasForeignKey(foto => foto.UsuarioId);

        builder.HasMany(usuario => usuario.Combinacoes)
            .WithOne(combinacao => combinacao.Usuario)
            .HasForeignKey(combinacao => combinacao.UsuarioId);
    });
}