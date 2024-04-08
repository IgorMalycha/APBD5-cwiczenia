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

    [HttpGet("{id}")]
    public IActionResult GetAnimal(int id)
    {
        var animal = StaticDataBase.getAnimalById(id);
        if (animal != null)
        {
            return Ok(animal);
        }
        else
        {
            return Ok("nie ma takiego zwierzecia");
        }
    }

    [HttpPut]
    public IActionResult PutAnimal(int id, string name, string category, int weight, string furColor)
    {
        StaticDataBase.animals.Add(new Animal(id, name, category, weight, furColor));
        return Ok();
    }

    [HttpPost("{id}")]
    public IActionResult PostAnimal(int id, string name, string category, int weight, string furColor)
    {
        for (int i = 0; i < StaticDataBase.animals.Count; i++)
        {
            if (StaticDataBase.animals[i].Id == id)
            {
                StaticDataBase.animals[i] = new Animal(id, name, category, weight, furColor);        
            }
        }
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteAnimal(int id)
    {
        for (int i = 0; i < StaticDataBase.animals.Count; i++)
        {
            if (StaticDataBase.animals[i].Id == id)
            {
                StaticDataBase.animals.RemoveAt(i);
            }
        }
        return Ok();
    }
    
}