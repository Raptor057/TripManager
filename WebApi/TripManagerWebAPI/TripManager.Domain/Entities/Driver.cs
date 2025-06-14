namespace TripManager.Domain.Entities;

public class Driver
{
    public int DriverId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public byte[] Photo { get; set; }

    public string Phone { get; set; }

    public string Email { get; set; }

    public string LicenseNumber { get; set; }

    public string DriverState { get; set; }

    public string Notes { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

}