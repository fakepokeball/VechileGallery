namespace Application.Requests.Car
{
    public class ToggleHeadlightsRequest
    {
        public Guid Id { get; set; }
        public bool HeadlightsOn { get; set; }
    }
}
