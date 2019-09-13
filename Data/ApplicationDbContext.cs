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
        
        
        public DbSet<MobileData> MobileDataBike { get; set; }
        public DbSet<Defect> Defects { get; set; }
        public DbSet<Possible> Possibles { get; set; }
        
        public DbSet<BluetoothLeDevice> BluetoothLeDevices { get; set; }
        public DbSet<Beacon> Beacons { get; set; }
        
    }
}