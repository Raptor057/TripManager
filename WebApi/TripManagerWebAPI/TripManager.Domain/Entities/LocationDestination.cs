namespace TripManager.Domain.Entities;

public class LocationDestination
{
    public int LocationDestinationId { get; set; }

    public string NameDestination { get; set; }

    public byte[] Photo { get; set; }

    public string AddressDestination { get; set; }

    public string CityDestination { get; set; }

    public string StateDestination { get; set; }

    public string CountryDestination { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

}