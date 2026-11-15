using Microsoft.EntityFrameworkCore;
using RefillService.Model;

namespace RefillService.Data2;

public class RefillDbContext : DbContext
{
    public RefillDbContext(DbContextOptions<RefillDbContext> options)
    : base(options)
    {
    }

    public DbSet<Refill> Refills { get; set; }
}