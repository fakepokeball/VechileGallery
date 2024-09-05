using Core.Enums;

namespace Application.Requests.Car
{
    public class GetCarListRequest
    {
        public Color? FilterByColor { get; set; }
    }
}
