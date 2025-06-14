namespace TripManager.Domain.Entities.Configuration;

public class Branches
{
    public int Id { get; set; }

    public int BusinessId { get; set; }

    public string BranchName { get; set; }

    public string PhoneNumber { get; set; }

    public string Email { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string Country { get; set; }

    public string Timezone { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

}