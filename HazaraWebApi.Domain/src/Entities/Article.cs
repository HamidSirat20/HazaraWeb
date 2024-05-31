namespace HazaraWebApi.Domain.src.Entities;

public class Article : BaseEntity
{
    public Guid Id { get; set; }
    public Guid AuthorId { get; set; }
    public string Title_EN { get; set; } = string.Empty;
    public string Title_FA { get; set; } = string.Empty;
    public string Content_EN { get; set; } = string.Empty;
    public string Content_FA { get; set; } = string.Empty;
    public byte[] Images { get; set; }
}
