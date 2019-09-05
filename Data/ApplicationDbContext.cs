using Microsoft.EntityFrameworkCore;
using TestGoogle.Models;

namespace TestGoogle.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        
        public DbSet<MobileData> MobileData { get; set; }
        public DbSet<Defect> Defects { get; set; }
        public DbSet<Possible> Possibles { get; set; }
        
    }
}