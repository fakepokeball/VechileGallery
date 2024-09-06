using Application.Requests.Bus;
using Application.Responses.Bus;

namespace Application.Services.Abstract
{
    public interface IBusService
    {
        Task<GetBusListResponse> GetBusesByColorAsync(GetBusListRequest request);
        Task<CreatedBusResponse> AddBusAsync(CreateBusRequest request);
        Task<GetBusByIdResponse> GetBusByIdAsync(GetBusByIdRequest request);
        Task<UpdatedBusResponse> UpdateBusAsync(UpdateBusRequest request);
        Task<DeletedBusResponse> DeleteBusAsync(DeleteBusRequest request);
    }
}
