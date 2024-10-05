namespace HazaraWebApi.Domain.src.Entities;

public class Member : BaseEntity
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public MembershipType MembershipType{ get; set; }
    public string Email { get; set; } = string.Empty;
    public string Password  { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; }

}

public enum MembershipType
{
    NormalMember,
    Admin
}
