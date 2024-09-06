using Core.Enums;

namespace Application.Responses.Boat
{
    public class GetBoatByIdResponse
    {
        public Guid Id { get; set; }
        public Color Color { get; set; }
        public int EnginePower { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

    }
}