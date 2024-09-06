using Application.BusinessRules;
using Application.Requests.Bus;
using Application.Responses.Bus;
using Application.Services.Abstract;
using AutoMapper;
using Core.Entities.Concrete;
using Infrastructure.Repositories.Abstract;

namespace Application.Services.Concrete
{
    public class BusService : IBusService
    {
        private readonly IBusRepository _busRepository;
        private readonly BusBusinessRules _busBusinessRules;
        private readonly IMapper _mapper;

        public BusService(IBusRepository busRepository, BusBusinessRules busBusinessRules, IMapper mapper)
        {
            _busRepository = busRepository;
            _busBusinessRules = busBusinessRules;
            _mapper = mapper;
        }

        public async Task<CreatedBusResponse> AddBusAsync(CreateBusRequest request)
        {
            var busToAdd = _mapper.Map<Bus>(request);

            Bus addedBus = await _busRepository.AddAsync(busToAdd);

            var response = _mapper.Map<CreatedBusResponse>(addedBus);

            return response;
        }
        public async Task<DeletedBusResponse> DeleteBusAsync(DeleteBusRequest request)
        {
            Bus? busToDelete = await _busRepository.GetAsync(predicate: bus => bus.Id == request.Id);

            _busBusinessRules.CheckIfBusExists(busToDelete);

            Bus deletedBus = await _busRepository.DeleteAsync(busToDelete!);
            var response = _mapper.Map<DeletedBusResponse>(deletedBus);

            return response;
        }

        public async Task<UpdatedBusResponse> UpdateBusAsync(UpdateBusRequest request)
        {
            Bus? busToUpdate = await _busRepository.GetAsync(predicate: bus => bus.Id == request.Id);
            _busBusinessRules.CheckIfBusExists(busToUpdate);

            busToUpdate = _mapper.Map(request, busToUpdate);
            Bus updatedBus = await _busRepository.UpdateAsync(busToUpdate!);

            var response = _mapper.Map<UpdatedBusResponse>(updatedBus);
            return response;
        }

        public async Task<GetBusByIdResponse> GetBusByIdAsync(GetBusByIdRequest request)
        {
            Bus? bus = await _busRepository.GetAsync(predicate: bus => bus.Id == request.Id);
            _busBusinessRules.CheckIfBusExists(bus);

            var response = _mapper.Map<GetBusByIdResponse>(bus);
            return response;
        }

        public async Task<GetBusListResponse> GetBusesByColorAsync(GetBusListRequest request)
        {
            IList<Bus> busList = await _busRepository.GetListAsync(
            predicate: bus =>
                (request.FilterByColor == null || bus.Color == request.FilterByColor)
                && (bus.DeletedAt == null)
            );
            var response = _mapper.Map<GetBusListResponse>(busList);
            return response;
        }
    }
}
