using Core.Enums;

namespace Application.Responses.Bus
{
    public class GetBusByIdResponse
    {
        public Guid Id { get; set; }
        public Color Color { get; set; }
        public int PassengerCapacity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}