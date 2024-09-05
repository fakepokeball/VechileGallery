using Core.Enums;

namespace Application.Dtos.Car
{
    public class CarListItemDto
    {
        public Guid Id { get; set; }
        public Color Color { get; set; }
        public int NumberOfWheels { get; set; }
        public bool HeadlightsOn { get; set; }
    }
}