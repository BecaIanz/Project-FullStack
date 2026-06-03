public class Animal : BaseModel
{
    //================PROPERTIES================
    public required string Nome {get;set;}
    public required string Tipo {get;set;}
    public required string Raca {get;set;}


    //================MY-RELATIONS================
    public required Ong Ong {get;set;}
    public required int OngId {get;set;}

    //================RELATIONS================
    public ICollection<AnimalFoto> Fotos {get;set;} = [];
    public ICollection<Combinacao> Combinacoes {get;set;} = [];
}