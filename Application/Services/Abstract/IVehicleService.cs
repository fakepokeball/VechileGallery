using Core.Entities.Concrete;
using Core.Enums;

namespace Application.Services.Abstract
{
    public interface IVehicleService
    {
        Task<IList<Car>> GetCarsByColorAsync(Color? color);
        Task<IList<Bus>> GetBusesByColorAsync(Color? color);
        Task<IList<Boat>> GetBoatsByColorAsync(Color? color);
    }
}
