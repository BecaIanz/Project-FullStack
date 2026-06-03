using System.Net.Http.Json;
public class SeedService
{
    private string nomeUsuario = "usuario";
    private string nomeOng = "ong";
    public async Task SeedData()
    {
        var usuario = ctx.Usuarios.Where(u => u.Nome == nomeUsuario).FirstOrDefault();
        if(usuario == null)
        {
            usuario = new Usuario{Nome=nomeUsuario, Descricao="Casa grande, quintal e dois filhos"};
            ctx.Usuarios.Add(usuario);
            await ctx.SaveChangesAsync();
        }
        var ong = ctx.Ongs.Where(o => o.Nome == nomeOng).FirstOrDefault();
        if(ong == null)
        {
            ong = new Ong{Nome=nomeOng};
            ctx.Ongs.Add(ong);
            await ctx.SaveChangesAsync();
        }

        int q = 5;
        if(ctx.Animais.Count() < q)
        {
            var toGen = await Generate(q);
            
            foreach(var a in toGen)
            {
                var animal = new Animal
                {
                    Nome= a.Nome,
                    Ong=ong,
                    OngId=ong.Id,
                    Raca=a.Raca,
                    Tipo=a.Tipo,
                };
                var foto = a.Imagem;

                ctx.Animais.Add(animal);
                await ctx.SaveChangesAsync();

                ctx.AnimalFotos.Add(new AnimalFoto{Url=foto, Animal=animal, AnimalId=animal.Id});
            }
            await ctx.SaveChangesAsync();
        }
    }











    private readonly HttpClient httpClient;
    private readonly Context ctx;
    public SeedService(HttpClient httpClient, Context ctx)
    {
        this.httpClient = httpClient;
        this.ctx = ctx;

        racas["raposa"] = GetRandomFoxImage;
    }

    private Dictionary<string, Func<Task<string>>> racas =
        new Dictionary<string, Func<Task<string>>>
    {
        {
            "pato",
            () => Task.FromResult("https://random-d.uk/api/randomimg")
        },
        {
            "gato",
            () => Task.FromResult("https://cataas.com/cat")
        },
        {
            "cachorro",
            () => Task.FromResult("https://placedog.net/800/600?random")
        }
    };


    public async Task<List<GenAnimal>> Generate(int q)
    {
        List<GenAnimal> list = [];
        for(int i=0; i<q; i++)
        {
            var r = Random.Shared.Next(0, racas.Keys.Count);
            var tipo = racas.Keys.ElementAt(r);
            GenAnimal animal = new GenAnimal
            (
                await GetRandomName(),
                await racas[tipo].Invoke(),
                "Vira lata",
                tipo
            );
            list.Add(animal);
        }
        return list;
    }





    private async Task<string> GetRandomFoxImage()
    {
        var response = await httpClient
            .GetFromJsonAsync<FoxResponse>(
                "https://randomfox.ca/floof/"
            );

        return response?.Image!;
    }
    public async Task<string> GetRandomName()
    {
        var response = await httpClient
            .GetFromJsonAsync<RandomUserResponse>(
                "https://randomuser.me/api/?nat=br"
            );

        var user = response?.Results.FirstOrDefault();

        return $"{user?.Name.First} {user?.Name.Last}";
    }
}


public class FoxResponse
{
    public string Image { get; set; } = string.Empty;
    public string Link { get; set; } = string.Empty;
}

public record RandomUserResponse(
    List<UserResult> Results
);

public record UserResult(
    Name Name
);

public record Name(
    string First,
    string Last
);

public record GenAnimal
(
    string Nome,
    string Raca,
    string Tipo,
    string Imagem
);