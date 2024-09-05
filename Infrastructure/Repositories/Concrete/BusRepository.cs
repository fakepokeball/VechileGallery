using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using Infrastructure.Data;
using Infrastructure.Repositories.Abstract;

namespace Infrastructure.Repositories.Concrete
{
    public class BusRepository : EfEntityRepositoryBase<Bus, VehicleGalleryDbContext>, IBusRepository
    {
        public BusRepository(VehicleGalleryDbContext context) : base(context) { }
    }
}
