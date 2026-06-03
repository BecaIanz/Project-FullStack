public class Usuario : BaseModel
{
    //================PROPERTIES================
    public required string Nome {get;set;}
    public required string Descricao {get;set;}

    //================RELATIONS================
    public ICollection<UsuarioFoto> Fotos {get;set;} = [];
    public ICollection<Combinacao> Combinacoes {get;set;} = [];
}