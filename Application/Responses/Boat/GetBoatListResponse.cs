using Application.Dtos.Boat;

namespace Application.Responses.Boat
{
    public class GetBoatListResponse
    {
        public ICollection<BoatListItemDto> Items { get; set; }
    }
}