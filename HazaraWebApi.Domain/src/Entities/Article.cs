namespace HazaraWebApi.Domain.src.Entities;

public class Article : BaseEntity
{
    public Guid AuthorId { get; set; }
    public string Title_EN { get; set; } = string.Empty;
    public string Title_FA { get; set; } = string.Empty;
    public string Content_EN { get; set; } = string.Empty;
    public string Content_FA { get; set; } = string.Empty;
    public List<Image> Images { get; set; } = new List<Image>();
}
