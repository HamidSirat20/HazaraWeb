using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HazaraWebApi.Domain.src.Entities;

namespace HazaraWebApi.Business.src.Dtos;

public class RegisterationReadDto
{
    public Guid Id { get; set; }
    public Guid EventId { get; set; }
    public Guid MemberId { get; set; }
    public Status status { get; set; }
}

public class RegisterationCreateDto
{
    public Guid EventId { get; set; }
    public Guid MemberId { get; set; }
    public Status status { get; set; }
}

public class RegisterationUpdateDto
{
    public Guid EventId { get; set; }
    public Guid MemberId { get; set; }
    public Status status { get; set; }
}
