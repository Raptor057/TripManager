namespace TripManager.Domain.Entities;

public class TripEvent
{
    public int TripEventId { get; set; }

    public int TripScheduleId { get; set; }

    public DateTime EventDateTime { get; set; }

    public string EventDescription { get; set; }

    public string EventType { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

}