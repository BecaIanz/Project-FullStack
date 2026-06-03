public class Combinacao : BaseModel
{
    //================PROPERTIES================
    public required bool Aceito {get;set;}
    public required bool Gostou {get;set;}


    //================MY-RELATIONS================
    public required Usuario Usuario {get;set;}
    public required int UsuarioId {get;set;}
    public required Animal Animal {get;set;}
    public required int AnimalId {get;set;}
}