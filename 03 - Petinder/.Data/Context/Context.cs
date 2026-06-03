using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;

public class Context(DbContextOptions<Context> ctx) : DbContext(ctx)
{
    public DbSet<Animal> Animais {get;set;}
    public DbSet<AnimalFoto> AnimalFotos {get;set;}
    public DbSet<Usuario> Usuarios {get;set;}
    public DbSet<UsuarioFoto> UsuarioFotos {get;set;}
    public DbSet<Combinacao> Combinacoes {get;set;}
    public DbSet<Ong> Ongs {get;set;}
    // public DbSet<_> _s {get;set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ConfigureAnimalClassMap(); 
        modelBuilder.ConfigureAnimalFotoClassMap(); 
        modelBuilder.ConfigureUsuarioClassMap(); 
        modelBuilder.ConfigureUsuarioFotoClassMap(); 
        modelBuilder.ConfigureCombinacaoClassMap(); 
        modelBuilder.ConfigureOngClassMap(); 
        // modelBuilder.Configur();

        base.OnModelCreating(modelBuilder);
    }
}