namespace TripManager.Domain.Entities.UTCDateTime;

public class SavedGlobalSettings
{
    public int Id { get; set; }

    public string Name { get; set; }

    public TimeSpan? CurrentUtcOffset { get; set; }

    public bool? IsCurrentlyDst { get; set; }

    public string Description { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

}