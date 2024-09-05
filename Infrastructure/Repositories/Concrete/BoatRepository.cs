using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using Infrastructure.Data;
using Infrastructure.Repositories.Abstract;

namespace Infrastructure.Repositories.Concrete
{
    public class BoatRepository : EfEntityRepositoryBase<Boat, VehicleGalleryDbContext>, IBoatRepository
    {
        public BoatRepository(VehicleGalleryDbContext context) : base(context) { }
    }
}
