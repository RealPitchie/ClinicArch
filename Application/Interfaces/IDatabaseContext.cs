using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IDatabaseContext
    {
        DbSet<Patient> Patients { get; set; }

        Task<int> SaveChanges(); 
    }
}