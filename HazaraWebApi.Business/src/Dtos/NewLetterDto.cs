using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HazaraWebApi.Business.src.Dtos;

public class NewsLetterReadDto
{
    public Guid Id { get; set; }
    public string Subject_EN { get; set; } = string.Empty;
    public string Subject_FA { get; set; } = string.Empty;
    public string Content_EN { get; set; } = string.Empty;
    public string Content_FA { get; set; } = string.Empty;
    public DateTime SentDate { get; set; }
}

public class NewsLetterCreateDto
{
    public string Subject_EN { get; set; } = string.Empty;
    public string Subject_FA { get; set; } = string.Empty;
    public string Content_EN { get; set; } = string.Empty;
    public string Content_FA { get; set; } = string.Empty;
    public DateTime SentDate { get; set; }
}

public class NewsLetterUpdateDto
{
    public string Subject_EN { get; set; } = string.Empty;
    public string Subject_FA { get; set; } = string.Empty;
    public string Content_EN { get; set; } = string.Empty;
    public string Content_FA { get; set; } = string.Empty;
    public DateTime SentDate { get; set; }
}
