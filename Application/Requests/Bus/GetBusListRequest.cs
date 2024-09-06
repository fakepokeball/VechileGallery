using Core.Enums;

namespace Application.Requests.Bus
{
    public class GetBusListRequest
    {
        public Color? FilterByColor { get; set; }
    }
}