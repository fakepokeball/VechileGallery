using Core.Enums;

namespace Application.Responses.Bus
{
    public class DeletedBusResponse
    {
        public Guid Id { get; set; }
        public Color Color { get; set; }
        public int PassengerCapacity { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}