namespace APBD_pracaDomowa4.Models;

public class Visite
{
    public String Data { get; set; }
    public int Id { get; set; }
    public string VisiteDescription { get; set; }
    public int Cost { get; set; }

    public Visite(string data, int id, string visiteDescription, int cost)
    {
        Data = data;
        Id = id;
        VisiteDescription = visiteDescription;
        Cost = cost;
    }
    
    
}