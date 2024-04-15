using Gestion_De_Taches.Models;
using Microsoft.EntityFrameworkCore;

namespace Gestion_De_Taches.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext( DbContextOptions<ApplicationDbContext>options) :base(options)
        {

        }
        public DbSet <Taches> taches { get; set; }
    }
}
