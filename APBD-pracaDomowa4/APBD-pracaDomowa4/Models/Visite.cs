namespace APBD_pracaDomowa4.Models;

public class Visite
{
    public String Data { get; set; }
    public Animal Animal { get; set; }
    public string VisiteDescription { get; set; }
    public int Cost { get; set; }

    public Visite(string data, Animal animal, string visiteDescription, int cost)
    {
        Data = data;
        Animal = animal;
        VisiteDescription = visiteDescription;
        Cost = cost;
    }
    
    
}