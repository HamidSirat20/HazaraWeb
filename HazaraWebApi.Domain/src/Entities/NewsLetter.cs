namespace HazaraWebApi.Domain.src.Entities;

public class NewsLetter : BaseEntity
{
    public string Subject_EN { get; set; } = string.Empty;
    public string Subject_FA { get; set; } = string.Empty;
    public string Content_EN { get; set; } = string.Empty;
    public string Content_FA { get; set; } = string.Empty;
    public DateTime SentDate { get; set; }
}
