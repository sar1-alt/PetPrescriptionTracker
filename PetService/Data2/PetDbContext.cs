using Microsoft.EntityFrameworkCore;
using PetService.Model;

namespace PetService.Data2;

public class PetDbContext : DbContext
{
    public PetDbContext(DbContextOptions<PetDbContext> options)
        : base(options)
    {
    }

    public DbSet<Pet> Pets { get; set; }
}