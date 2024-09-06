using Core.Enums;

namespace Application.Requests.Boat
{
    public class CreateBoatRequest
    {
        public Color Color { get; set; }
        public int EnginePower { get; set; }
    }
}