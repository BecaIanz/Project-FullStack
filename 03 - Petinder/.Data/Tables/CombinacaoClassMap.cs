using Microsoft.EntityFrameworkCore;

public static class CombinacaoClassMap
{
    public static void ConfigureCombinacaoClassMap(this ModelBuilder modelBuilder)
    => modelBuilder.Entity<Combinacao>(builder =>
    {
        builder.HasKey(combinacao => combinacao.Id);
        builder.Property(combinacao => combinacao.Id)
            .HasColumnName("id");
        builder.ToTable("tb_combinacao");

    //================PROPERTIES================
        builder.Property(combinacao => combinacao.Aceito)
            .HasColumnName("aceito")
            .IsRequired();
        builder.Property(combinacao => combinacao.Gostou)
            .HasColumnName("gostou")
            .IsRequired();

    //================MY-RELATIONS================
        builder.Property(combinacao => combinacao.UsuarioId)
            .HasColumnName("usuario_id")
            .IsRequired();
        builder.HasOne(combinacao => combinacao.Usuario)
            .WithMany(usuario => usuario.Combinacoes)
            .HasForeignKey(combinacao => combinacao.UsuarioId);

        builder.Property(combinacao => combinacao.UsuarioId)
            .HasColumnName("animal_id")
            .IsRequired();
        builder.HasOne(combinacao => combinacao.Animal)
            .WithMany(animal => animal.Combinacoes)
            .HasForeignKey(combinacao => combinacao.AnimalId);
    });
}