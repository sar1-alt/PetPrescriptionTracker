using Microsoft.EntityFrameworkCore;
using PrescriptionService.Model;

namespace PrescriptionService.Data2;

public class PrescriptionDbContext : DbContext
{
    public PrescriptionDbContext(DbContextOptions<PrescriptionDbContext> options) 
    : base(options)
    {
    }

    public DbSet<Prescription> Prescriptions { get; set; }
}