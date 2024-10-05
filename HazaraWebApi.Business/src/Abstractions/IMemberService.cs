using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper.Execution;
using HazaraWebApi.Business.src.Dtos;

namespace HazaraWebApi.Business.src.Abstractions;

public interface IMemberService
    : IBaseService<Member, MemberReadDto, MemberCreateDto, MemberUpdateDto>
{
    MemberReadDto UpdatePassword(Guid id, string newPassword);
    // MemberReadDto GetProfile(Guid id);
}
