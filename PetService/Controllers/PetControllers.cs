using Microsoft.AspNetCore.Mvc;
using PetService.Data2;
using PetService.Model;

namespace PetService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PetsController : ControllerBase
{
    private readonly PetDbContext _context;

    public PetsController(PetDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetPets()
    {
        return Ok(_context.Pets.ToList());
    }
}