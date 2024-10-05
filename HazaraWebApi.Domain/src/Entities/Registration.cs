namespace HazaraWebApi.Domain.src.Entities;

public class Registration : BaseEntity
{
    public Guid EventId { get; set; }
    public Guid MemberId { get; set; }
    public Status status { get; set; }
}

public enum Status
{
    confirmed,
    cancelled,
    waitingList
}
