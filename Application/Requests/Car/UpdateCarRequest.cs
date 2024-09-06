using Core.Enums;

namespace Application.Requests.Car
{
    public class UpdateCarRequest
    {
        public Guid Id { get; set; }
        public Color Color { get; set; }
        public int NumberOfWheels { get; set; }
        public bool HeadlightsOn { get; set; }
    }
}
