using Core.Enums;

namespace Application.Requests.Boat
{
    public class UpdateBoatRequest
    {
        public Guid Id { get; set; }
        public Color Color { get; set; }
        public int EnginePower { get; set; }
    }
}