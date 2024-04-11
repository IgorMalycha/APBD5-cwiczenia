
using APBD_pracaDomowa4.Models;

using Microsoft.AspNetCore.Mvc;

namespace APBD_pracaDomowa4.Controllers;


[ApiController]
[Route("visits")]
public class VisiteController : ControllerBase
{
    
    public static List<Visite> visites = new List<Visite>()
    {
        new Visite("02.03.2024", 1, "odrobaczanie", 50),
        new Visite("14.01.2024", 2, "ostrzenie dzioba", 400)
    };

    [HttpGet]
    public IActionResult GetVisites(int id)
    {
        var animalVisits = visites.Where(v => v.Id == id).ToList();
        return Ok(animalVisits);
    }

    [HttpPost]
    public IActionResult CreateVisite(Visite visite)
    {
        visites.Add(visite);
        return StatusCode(StatusCodes.Status201Created);
    }
}