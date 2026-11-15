using Microsoft.AspNetCore.Mvc;
using RefillService.Data2;
using RefillService.Model;

namespace RefillService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RefillsController : ControllerBase
{
    private readonly RefillDbContext _context;

    public RefillsController(RefillDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_context.Refills.ToList());
    }

    [HttpPost]
    public IActionResult AddRefill(Refill refill)
    {
        _context.Refills.Add(refill);
        _context.SaveChanges();

        return CreatedAtAction(nameof(GetAll), refill);
    }
}