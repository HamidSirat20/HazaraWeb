namespace HazaraWebApi.Domain.src.Entities;

public class Event : BaseEntity
{
    public Guid Id { get; set; }
    public string Title_EN { get; set; } = string.Empty;
    public string Title_FA { get; set; } = string.Empty;
    public string Description_EN { get; set; } = string.Empty;
    public string Description_FA { get; set; } = string.Empty;
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string Location { get; set; } = string.Empty;
    public bool IsPublic { get; set; }
    public string Avatar { get; set; } = string.Empty;
}
