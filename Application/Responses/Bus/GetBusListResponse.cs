using Application.Dtos.Bus;

namespace Application.Responses.Bus
{
    public class GetBusListResponse
    {
        public ICollection<BusListItemDto> Items { get; set; }
    }
}