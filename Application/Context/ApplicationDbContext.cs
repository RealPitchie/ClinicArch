using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

public class DatabaseContext : DbContext, IDatabaseContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
    {
    }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Man> MenStats { get; set; }
    public DbSet<Woman> WomenStats { get; set; }
    
    public async Task<int> SaveChanges()
    {
        return await base.SaveChangesAsync();
    }
}