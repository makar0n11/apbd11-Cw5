using apbd11_Cw5.database;
//using apbd11_Cw5.Endpoints;
using apbd11_Cw5.Models;
using Microsoft.AspNetCore.Mvc;

namespace apbd11_Cw5.Controllers;

[ApiController]
[Route("/animals")]

public class AnimalController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = StaticData._animals;
        return Ok(animals);

    }
    [HttpGet("{id:int}")]
    public IActionResult GetAnimals(int id)
    {
        var animal = StaticData._animals.FirstOrDefault(a => a.Id == id);
        if (animal == null)
        {
            return NotFound($"Animal with id {id} was not found");
        }
        return Ok(animal);

    }
    [HttpPost]
    public IActionResult AddAnimal(Animal animal)
    {
        StaticData._animals.Add(animal);
        return StatusCode(StatusCodes.Status201Created);

    }

    [HttpPut("{id:int}")]
    public IActionResult UpdateAnimal(int id, Animal animal)
    {
        var animalToEdit = StaticData._animals.FirstOrDefault(a => a.Id == id);
        if (animalToEdit == null)
        {
            return NotFound($"Animal with id {id} was not found");
        }

        StaticData._animals.Remove(animalToEdit);
        StaticData._animals.Add(animal);
        return NoContent();
    }
    
    [HttpDelete("{id:int}")]
    public IActionResult DeleteStudent(int id)
    {
        var animalToRemove= StaticData._animals.FirstOrDefault(a => a.Id == id);
        if (animalToRemove == null)
        {
            return NoContent();
        }

        StaticData._animals.Remove(animalToRemove);
        return NoContent();
    }
}