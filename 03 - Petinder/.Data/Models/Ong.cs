public class Ong : BaseModel
{
    //================PROPERTIES================
    public required string Nome {get;set;}

    //================RELATIONS================
    public ICollection<Animal> Animais {get;set;} = [];
}