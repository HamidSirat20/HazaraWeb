using HazaraWebApi.Domain.src.Entities;

namespace HazaraWebApi.Business.src.Dtos;

public class ArticleReadDto
{
    public Guid Id { get; set; }
    public Guid AuthorId { get; set; }
    public string Title_EN { get; set; } = string.Empty;
    public string Title_FA { get; set; } = string.Empty;
    public string Content_EN { get; set; } = string.Empty;
    public string Content_FA { get; set; } = string.Empty;
    public List<Image> Images { get; set; } = new List<Image>();
}

public class ArticleCreateDto
{
    public string Title_EN { get; set; } = string.Empty;
    public string Title_FA { get; set; } = string.Empty;
    public string Content_EN { get; set; } = string.Empty;
    public string Content_FA { get; set; } = string.Empty;
    public List<Image> Images { get; set; } = new List<Image>();
}

public class ArticleUpdateDto
{
    public string Title_EN { get; set; } = string.Empty;
    public string Title_FA { get; set; } = string.Empty;
    public string Content_EN { get; set; } = string.Empty;
    public string Content_FA { get; set; } = string.Empty;
    public List<Image> Images { get; set; } = new List<Image>();
}
