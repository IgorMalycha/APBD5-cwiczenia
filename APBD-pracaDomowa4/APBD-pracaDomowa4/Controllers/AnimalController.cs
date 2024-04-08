using APBD_pracaDomowa4.DataBase;
using APBD_pracaDomowa4.Models;
using Microsoft.AspNetCore.Mvc;

namespace APBD_pracaDomowa4.Controllers;


[ApiController]
[Route("[controller]")]
public class AnimalController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok(StaticDataBase.animals[0]);
    }

    [HttpGet("{id:int}")]
    public IActionResult GetAnimal(int id)
    {
        var animal = StaticDataBase.getAnimalById(id);
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
        StaticDataBase.animals.Add(animal);
        return StatusCode(StatusCodes.Status201Created);
    }

    [HttpPut("{id:int}")]
    public IActionResult UpdateAnimal(int id, Animal animal)
    {
        for (int i = 0; i < StaticDataBase.animals.Count; i++)
        {
            if (StaticDataBase.animals[i].Id == id)
            {
                StaticDataBase.animals[i] = animal;
                return NoContent();
            }
        }
        return NotFound($"Animal with {id} was not found");
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        for (int i = 0; i < StaticDataBase.animals.Count; i++)
        {
            if (StaticDataBase.animals[i].Id == id)
            {
                StaticDataBase.animals.RemoveAt(i);
                return NoContent();
            }
        }
        return NotFound($"Animal with {id} was not found");
    }
    
}