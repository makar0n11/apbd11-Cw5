using Microsoft.AspNetCore.Mvc;

namespace apbd11_Cw5.Controllers;

[ApiController]
[Route("/animals-controller")]

public class AnimalController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok();

    }
    [HttpGet("{id}")]
    public IActionResult GetAnimals(int id)
    {
        return Ok(id);

    }
    [HttpPost]
    public IActionResult AddAnimal()
    {
        return Created();

    }
}