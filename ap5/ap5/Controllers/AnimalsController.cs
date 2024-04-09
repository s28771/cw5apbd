using ap5.Database;
using Microsoft.AspNetCore.Mvc;

namespace ap5.Controllers;
[ApiController]
[Route("/animals-controller")]
//[Route("[controller]")]
public class AnimalsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = new MockDb().Animals;
        return Ok(animals);
    }

    [HttpPost]
    public IActionResult AddAnimal()
    {
        return Created();
    }
}