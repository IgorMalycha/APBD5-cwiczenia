using APBD_pracaDomowa4.Models;

namespace APBD_pracaDomowa4.DataBase;

public class StaticDataBase
{
    public static List<Animal> animals = new List<Animal>()
    {
        new Animal(1, "Fred", "kot", 15, "ruda"),
        new Animal(2, "Fredek", "kot", 11, "czarna"),
        new Animal(3, "Rex", "pies", 25, "brazowa"),
        new Animal(4, "krotka", "papuga", 1, "kolorowa")
    };

    public static List<Visite> visites = new List<Visite>()
    {
        new Visite("02.03.2024", animals[0], "odrobaczanie", 50),
        new Visite("14.01.2024", animals[4], "ostrzenie dzioba", 400)
    };

    public static Animal getAnimalById(int id)
    {
        foreach (Animal animal in animals)
        {
            if (animal.Id == id)
            {
                return animal;
            }
        }
        return null;
    }
    
}