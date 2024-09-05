using Core.Enums;

namespace Application.Requests.Car
{
    public class CreateCarRequest
    {
        public Color Color { get; set; }
        public int NumberOfWheels { get; set; }
        public bool HeadlightsOn { get; set; }
    }
}