using APBD_pracaDomowa4.DataBase;
using APBD_pracaDomowa4.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace APBD_pracaDomowa4.Controllers;


[ApiController]
[Route("visits")]
public class VisiteController : ControllerBase
{

    [HttpGet]
    public IActionResult GetVisites(int id)
    {
        List<Visite> visites = new List<Visite>();
        foreach (Visite visite in StaticDataBase.visites)
        {
            if (visite.Animal.Id == id)
            {
                visites.Add(visite);
            }
        }
        return Ok(visites);
    }

    [HttpPost]
    public IActionResult CreateVisite(Visite visite)
    {
        StaticDataBase.visites.Add(visite);
        return StatusCode(StatusCodes.Status201Created);
    }
}