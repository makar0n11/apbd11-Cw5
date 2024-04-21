using apbd11_Cw5.Models;

namespace apbd11_Cw5.database;

public class StaticData
{
    public static readonly List<Animal> _animals = new List<Animal>()
    {
        new Animal(1,"Feliks","Dog",148,"White"),
        new Animal(2,"Phelix","Cat",28,"Black"),
        new Animal(3,"Pablo","Tiger",420,"Orange")
        
    };
    
    // public static List<Visit> visits  = new List<Visit>()
    // {
    //     
    // }

}