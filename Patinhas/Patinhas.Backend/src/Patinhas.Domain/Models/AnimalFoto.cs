public class AnimalFoto : BaseModel
{
    //================PROPERTIES================
    public required string Url {get;set;}


    //================MY-RELATIONS================
    public required Animal Animal {get;set;}
    public required int AnimalId {get;set;}
}