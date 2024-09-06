using Application.BusinessRules;
using Application.Requests.Boat;
using Application.Responses.Boat;
using Application.Services.Abstract;
using AutoMapper;
using Core.Entities.Concrete;
using Infrastructure.Repositories.Abstract;

namespace Application.Services.Concrete
{
    public class BoatService : IBoatService
    {
        private readonly IBoatRepository _boatRepository;
        private readonly BoatBusinessRules _boatBusinessRules;
        private readonly IMapper _mapper;

        public BoatService(IBoatRepository boatRepository, BoatBusinessRules boatBusinessRules, IMapper mapper)
        {
            _boatRepository = boatRepository;
            _boatBusinessRules = boatBusinessRules;
            _mapper = mapper;
        }

        public async Task<CreatedBoatResponse> AddBoatAsync(CreateBoatRequest request)
        {
            var boatToAdd = _mapper.Map<Boat>(request);

            Boat addedBoat = await _boatRepository.AddAsync(boatToAdd);

            var response = _mapper.Map<CreatedBoatResponse>(addedBoat);

            return response;
        }
        public async Task<DeletedBoatResponse> DeleteBoatAsync(DeleteBoatRequest request)
        {
            Boat? boatToDelete = await _boatRepository.GetAsync(predicate: boat => boat.Id == request.Id);

            _boatBusinessRules.CheckIfBoatExists(boatToDelete);

            Boat deletedBoat = await _boatRepository.DeleteAsync(boatToDelete!);
            var response = _mapper.Map<DeletedBoatResponse>(deletedBoat);

            return response;
        }

        public async Task<UpdatedBoatResponse> UpdateBoatAsync(UpdateBoatRequest request)
        {
            Boat? boatToUpdate = await _boatRepository.GetAsync(predicate: boat => boat.Id == request.Id);
            _boatBusinessRules.CheckIfBoatExists(boatToUpdate);

            boatToUpdate = _mapper.Map(request, boatToUpdate);
            Boat updatedBoat = await _boatRepository.UpdateAsync(boatToUpdate!);

            var response = _mapper.Map<UpdatedBoatResponse>(updatedBoat);
            return response;
        }

        public async Task<GetBoatByIdResponse> GetBoatByIdAsync(GetBoatByIdRequest request)
        {
            Boat? boat = await _boatRepository.GetAsync(predicate: boat => boat.Id == request.Id);
            _boatBusinessRules.CheckIfBoatExists(boat);

            var response = _mapper.Map<GetBoatByIdResponse>(boat);
            return response;
        }

        public async Task<GetBoatListResponse> GetBoatsByColorAsync(GetBoatListRequest request)
        {
            IList<Boat> boatList = await _boatRepository.GetListAsync(
            predicate: boat =>
                (request.FilterByColor == null || boat.Color == request.FilterByColor)
                && (boat.DeletedAt == null)
            );
            var response = _mapper.Map<GetBoatListResponse>(boatList);
            return response;
        }


    }
}
