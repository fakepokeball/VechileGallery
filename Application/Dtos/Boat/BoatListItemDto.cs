using Core.Enums;

namespace Application.Dtos.Boat
{
    public class BoatListItemDto
    {
        public Guid Id { get; set; }
        public Color Color { get; set; }
        public int EnginePower { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}