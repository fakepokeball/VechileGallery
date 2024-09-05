using Application.Dtos.Car;

namespace Application.Responses.Car
{
    public class GetCarListResponse
    {
        public ICollection<CarListItemDto> Items { get; set; }
    }
}
