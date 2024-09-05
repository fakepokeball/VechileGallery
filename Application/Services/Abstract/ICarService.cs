using Application.Requests.Car;
using Application.Responses.Car;

namespace Application.Services.Abstract
{
    public interface ICarService
    {
        Task<GetCarListResponse> GetCarsByColorAsync(GetCarListRequest request);
        Task<CreatedCarResponse> AddCarAsync(CreateCarRequest request);
        Task<GetCarByIdResponse> GetCarByIdAsync(GetCarByIdRequest request);
        Task<UpdatedCarResponse> UpdateCarAsync(UpdateCarRequest request);
        Task<DeletedCarResponse> DeleteCarAsync(DeleteCarRequest request);
    }
}
