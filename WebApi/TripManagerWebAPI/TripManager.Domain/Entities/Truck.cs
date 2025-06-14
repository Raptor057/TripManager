namespace TripManager.Domain.Entities;

public class Truck
{
    public int TruckId { get; set; }

    public string LicensePlate { get; set; }

    public string Model { get; set; }

    public string Brand { get; set; }

    public int? ManufactureYear { get; set; }

    public int? Capacity { get; set; }

    public string TruckState { get; set; }

    public string Notes { get; set; }

    public byte[] Photo { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

}