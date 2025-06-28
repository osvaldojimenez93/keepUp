namespace keepUp.API.Models;

public class MaintenanceTask
{
    public required string Id { get; set; }
    public required string AssetId { get; set; }
    public required string Title { get; set; }
    public required List<string> Steps { get; set; }
    public required string Frequency { get; set; }
}