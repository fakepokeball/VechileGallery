using Application.Services.Abstract;
using Core.Entities.Concrete;
using Core.Enums;
using Infrastructure.Repositories.Abstract;

namespace Application.Services.Concrete
{
    public class VehicleService : IVehicleService
    {
        private readonly ICarRepository _carRepository;
        private readonly IBusRepository _busRepository;
        private readonly IBoatRepository _boatRepository;

        public VehicleService(ICarRepository carRepository, IBusRepository busRepository, IBoatRepository boatRepository)
        {
            _carRepository = carRepository;
            _busRepository = busRepository;
            _boatRepository = boatRepository;
        }

        public async Task<IList<Car>> GetCarsByColorAsync(Color? color)
        {
            return await _carRepository.GetListAsync(c => !color.HasValue || c.Color == color.Value);
        }

        public async Task<IList<Bus>> GetBusesByColorAsync(Color? color)
        {
            return await _busRepository.GetListAsync(b => !color.HasValue || b.Color == color.Value);
        }

        public async Task<IList<Boat>> GetBoatsByColorAsync(Color? color)
        {
            return await _boatRepository.GetListAsync(b => !color.HasValue || b.Color == color.Value);
        }
    }
}
