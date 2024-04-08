namespace APBD_pracaDomowa4.Models;

public class Animal
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string Category { get; set; }
    public int Weight { get; set; }
    public string FurColor { get; set; }

    public Animal(int id, string firstName, string category, int weight, string furColor)
    {
        Id = id;
        FirstName = firstName;
        Category = category;
        Weight = weight;
        FurColor = furColor;
    }
}