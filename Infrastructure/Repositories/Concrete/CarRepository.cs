using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using Infrastructure.Data;
using Infrastructure.Repositories.Abstract;

namespace Infrastructure.Repositories.Concrete
{
    public class CarRepository : EfEntityRepositoryBase<Car, VehicleGalleryDbContext>, ICarRepository
    {
        public CarRepository(VehicleGalleryDbContext context) : base(context) { }
    }
}
