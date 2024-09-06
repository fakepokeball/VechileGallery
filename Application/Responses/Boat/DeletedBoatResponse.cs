using Core.Enums;

namespace Application.Responses.Boat
{
    public class DeletedBoatResponse
    {
        public Guid Id { get; set; }
        public Color Color { get; set; }
        public int EnginePower { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}