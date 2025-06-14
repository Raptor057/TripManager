namespace TripManager.Domain.Entities;

public class LocationOrigin
{
    public int LocationOriginId { get; set; }

    public string NameOrigin { get; set; }

    public byte[] Photo { get; set; }

    public string AddressOrigin { get; set; }

    public string CityOrigin { get; set; }

    public string StateOrigin { get; set; }

    public string CountryOrigin { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

}