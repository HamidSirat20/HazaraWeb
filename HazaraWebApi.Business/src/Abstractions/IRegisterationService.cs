using HazaraWebApi.Business.src.Dtos;
using HazaraWebApi.Domain.src.Entities;

namespace HazaraWebApi.Business.src.Abstractions;

public interface IRegisterationService : IBaseService<Registration, RegisterationReadDto, RegisterationCreateDto, RegisterationUpdateDto>
{

}
