namespace TripManager.Domain.Entities;

public class TripPassengers
{
    public int TripPassengerId { get; set; }

    public int TripScheduleId { get; set; }

    public int PassengerId { get; set; }

    public string SeatNumber { get; set; }

    public DateTime? CheckInTime { get; set; }

    public string TicketNumber { get; set; }

    public string Notes { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

}