using BlocoNotasVideoYoutube.Models;
using Microsoft.EntityFrameworkCore;

namespace BlocoNotasVideoYoutube.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<Nota> Notas { get; set; }
    }
}
