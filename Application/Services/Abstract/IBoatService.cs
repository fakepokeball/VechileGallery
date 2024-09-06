using Application.Requests.Boat;
using Application.Responses.Boat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Abstract
{
    public interface IBoatService
    {
        Task<GetBoatListResponse> GetBoatsByColorAsync(GetBoatListRequest request);
        Task<CreatedBoatResponse> AddBoatAsync(CreateBoatRequest request);
        Task<GetBoatByIdResponse> GetBoatByIdAsync(GetBoatByIdRequest request);
        Task<UpdatedBoatResponse> UpdateBoatAsync(UpdateBoatRequest request);
        Task<DeletedBoatResponse> DeleteBoatAsync(DeleteBoatRequest request);
    }
}
