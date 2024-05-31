using HazaraWebApi.Domain.src.Entities;

namespace HazaraWebApi.Domain.src.Abstractions;

public interface IMemberRepo : IBaseRepo<Member>
{
    Task<Member> CreateAdmin(Member member);
    Task<Member> UpdatePassword(Member member);
    Task<Member?> FindUserByEmail(string email);
}
