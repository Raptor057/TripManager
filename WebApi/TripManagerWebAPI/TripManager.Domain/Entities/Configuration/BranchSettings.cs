namespace TripManager.Domain.Entities.Configuration;

public class BranchSettings
{
    public int Id { get; set; }

    public int BranchId { get; set; }

    public string SettingKey { get; set; }

    public string SettingValue { get; set; }

    public string Description { get; set; }

    public DateTime UpdatedAt { get; set; }

}