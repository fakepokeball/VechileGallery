using Core.Enums;

namespace Application.Requests.Bus
{
    public class UpdateBusRequest
    {
        public Guid Id { get; set; }
        public Color Color { get; set; }
        public int PassengerCapacity { get; set; }
    }
}