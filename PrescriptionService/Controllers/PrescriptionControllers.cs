using Microsoft.AspNetCore.Mvc;
using PrescriptionService.Data2;
using PrescriptionService.Model;

namespace PrescriptionService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PrescriptionsController : ControllerBase
{
    private readonly PrescriptionDbContext _context;

    public PrescriptionsController(PrescriptionDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_context.Prescriptions.ToList());
    }

    [HttpPost]
    public IActionResult AddPrescription(Prescription prescription)
    {
        _context.Prescriptions.Add(prescription);
        _context.SaveChanges();

        return CreatedAtAction(nameof(GetAll), prescription);
    }
}