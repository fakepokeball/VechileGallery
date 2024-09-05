using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class VehicleGalleryDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Boat> Boats { get; set; }

        public VehicleGalleryDbContext(DbContextOptions<VehicleGalleryDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
