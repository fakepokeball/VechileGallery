using Application.BusinessRules;
using Application.Requests.Car;
using Application.Responses.Car;
using Application.Services.Abstract;
using AutoMapper;
using Core.Entities.Concrete;
using Infrastructure.Repositories.Abstract;

namespace Application.Services.Concrete
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        private readonly CarBusinessRules _carBusinessRules;
        private readonly IMapper _mapper;

        public CarService(ICarRepository carRepository, CarBusinessRules carBusinessRules, IMapper mapper)
        {
            _carRepository = carRepository;
            _carBusinessRules = carBusinessRules;
            _mapper = mapper;
        }

        public async Task<CreatedCarResponse> AddCarAsync(CreateCarRequest request)
        {
            var carToAdd = _mapper.Map<Car>(request);

            Car addedCar = await _carRepository.AddAsync(carToAdd);

            var response = _mapper.Map<CreatedCarResponse>(addedCar);

            return response;
        }
        public async Task<DeletedCarResponse> DeleteCarAsync(DeleteCarRequest request)
        {
            Car? carToDelete = await _carRepository.GetAsync(predicate: car => car.Id == request.Id);

            _carBusinessRules.CheckIfCarExists(carToDelete);

            Car deletedCar = await _carRepository.DeleteAsync(carToDelete!);
            var response = _mapper.Map<DeletedCarResponse>(deletedCar);

            return response;
        }

        public async Task<UpdatedCarResponse> UpdateCarAsync(UpdateCarRequest request)
        {
            Car? carToUpdate = await _carRepository.GetAsync(predicate: car => car.Id == request.Id);
            _carBusinessRules.CheckIfCarExists(carToUpdate);

            carToUpdate = _mapper.Map(request, carToUpdate);
            Car updatedCar = await _carRepository.UpdateAsync(carToUpdate!);

            var response = _mapper.Map<UpdatedCarResponse>(updatedCar);
            return response;
        }

        public async Task<GetCarByIdResponse> GetCarByIdAsync(GetCarByIdRequest request)
        {
            Car? car = await _carRepository.GetAsync(predicate: car => car.Id == request.Id);
            _carBusinessRules.CheckIfCarExists(car);

            var response = _mapper.Map<GetCarByIdResponse>(car);
            return response;
        }

        public async Task<GetCarListResponse> GetCarsByColorAsync(GetCarListRequest request)
        {
            IList<Car> carList = await _carRepository.GetListAsync(
            predicate: car =>
                (request.FilterByColor == null || car.Color == request.FilterByColor)
                && (car.DeletedAt == null)
            );
            var response = _mapper.Map<GetCarListResponse>(carList);
            return response;
        }

    }
}
