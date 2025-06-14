namespace TripManager.Domain.Entities;

public class Passenger
{
    public int PassengerId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public byte[] Photo { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public string DocumentNumber { get; set; }

    public byte[] DocumentPhoto { get; set; }

    public string Notes { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

}