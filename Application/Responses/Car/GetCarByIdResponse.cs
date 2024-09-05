using Core.Enums;

namespace Application.Responses.Car
{
    public class GetCarByIdResponse
    {
        public Guid Id { get; set; }
        public Color Color { get; set; }
        public int NumberOfWheels { get; set; }
        public bool HeadlightsOn { get; set; }
    }
}
