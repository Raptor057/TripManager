namespace TripManager.Domain.Entities.Configuration;

public class BusinessInfo
{
    public int Id { get; set; }

    public string BusinessName { get; set; }

    public string LegalName { get; set; }

    public string RFC { get; set; }

    public string PhoneNumber { get; set; }

    public string Email { get; set; }

    public string Website { get; set; }

    public string Street { get; set; }

    public string ExteriorNumber { get; set; }

    public string InteriorNumber { get; set; }

    public string Neighborhood { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string PostalCode { get; set; }

    public string Country { get; set; }

    public byte[] Logo { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

}