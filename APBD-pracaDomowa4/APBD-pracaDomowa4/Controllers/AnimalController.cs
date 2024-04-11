
using APBD_pracaDomowa4.Models;
using Microsoft.AspNetCore.Mvc;

namespace APBD_pracaDomowa4.Controllers;


[ApiController]
[Route("[controller]")]
public class AnimalController : ControllerBase
{
    
    public static List<Animal> animals = new List<Animal>()
    {
        new Animal(1, "Fred", "kot", 15, "ruda"),
        new Animal(2, "Fredek", "kot", 11, "czarna"),
        new Animal(3, "Rex", "pies", 25, "brazowa"),
        new Animal(4, "krotka", "papuga", 1, "kolorowa")
    };
    
    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok(animals);
    }

    [HttpGet("{id:int}")]
    public IActionResult GetAnimal(int id)
    {
        var animal = getAnimalById(id);
        if (animal != null)
        {
            return Ok(animal);
        }
        else
        {
            return NotFound($"Animal with {id} was not found");
        }
    }

    [HttpPost]
    public IActionResult CreateAnimal(Animal animal)
    {
        animals.Add(animal);
        return StatusCode(StatusCodes.Status201Created);
    }

    [HttpPut("{id:int}")]
    public IActionResult UpdateAnimal(int id, Animal animal)
    {
        for (int i = 0; i < animals.Count; i++)
        {
            if (animals[i].Id == id)
            {
                animals[i] = animal;
                return NoContent();
            }
        }
        return NotFound($"Animal with {id} was not found");
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        for (int i = 0; i < animals.Count; i++)
        {
            if (animals[i].Id == id)
            {
                animals.RemoveAt(i);
                return NoContent();
            }
        }
        return NotFound($"Animal with {id} was not found");
    }
    
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