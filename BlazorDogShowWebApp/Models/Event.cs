namespace BlazorDogShowWebApp.Models
{
    public class Event
    {
        public int Id { get; set; } = 1;
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now;
        public string EventName { get; set; } = String.Empty;
        public string EventDescription { get; set; } = String.Empty;

    }
}
