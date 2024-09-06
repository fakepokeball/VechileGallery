using Core.Enums;

namespace Application.Requests.Bus
{
    public class CreateBusRequest
    {
        public Color Color { get; set; }
        public int PassengerCapacity { get; set; }
    }
}