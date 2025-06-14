namespace TripManager.Domain.Entities;

public class TripSchedule
{
    public int TripScheduleId { get; set; }

    public int LocationOriginId { get; set; }

    public int LocationDestinationId { get; set; }

    public int TruckId { get; set; }

    public int DriverId { get; set; }

    public DateTime ScheduledDeparture { get; set; }

    public DateTime? ScheduledArrival { get; set; }

    public DateTime? ActualDeparture { get; set; }

    public DateTime? ActualArrival { get; set; }

    public string TripScheduleState { get; set; }

    public string Notes { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

}