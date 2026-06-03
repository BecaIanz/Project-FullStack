using Microsoft.EntityFrameworkCore;

public static class UsuarioFotoClassMap
{
    public static void ConfigureUsuarioFotoClassMap(this ModelBuilder modelBuilder)
    => modelBuilder.Entity<UsuarioFoto>(builder =>
    {
        builder.HasKey(usuarioFoto => usuarioFoto.Id);
        builder.Property(usuarioFoto => usuarioFoto.Id)
            .HasColumnName("id");
        builder.ToTable("tb_usuario_foto");

    //================PROPERTIES================
        builder.Property(usuarioFoto => usuarioFoto.Url)
            .HasColumnName("url")
            .IsRequired();

    //================MY-RELATIONS================
        builder.HasOne(usuarioFoto => usuarioFoto.Usuario)
            .WithMany(usuario => usuario.Fotos)
            .HasForeignKey(usuarioFoto => usuarioFoto.UsuarioId);
    });
}