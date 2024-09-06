using Application.Requests.Car;
using Application.Responses.Car;
using Core.Entities.Concrete;

namespace Application.Services.Abstract
{
    public interface ICarService
    {
        Task<GetCarListResponse> GetCarsByColorAsync(GetCarListRequest request);
        Task<CreatedCarResponse> AddCarAsync(CreateCarRequest request);
        Task<GetCarByIdResponse> GetCarByIdAsync(GetCarByIdRequest request);
        Task<UpdatedCarResponse> UpdateCarAsync(UpdateCarRequest request);
        Task<DeletedCarResponse> DeleteCarAsync(DeleteCarRequest request);
        Task<Car> ToggleHeadlightsAsync(Guid id, bool headlightsOn);
    }
}
