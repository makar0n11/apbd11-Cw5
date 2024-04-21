namespace apbd11_Cw5.Models;

public class Visit
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public Animal Animal { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }

    public Visit(int id, DateTime date, Animal animal, string description, double price)
    {
        Id = id;
        Date = date;
        Animal = animal;
        Description = description;
        Price = price;
    }
}