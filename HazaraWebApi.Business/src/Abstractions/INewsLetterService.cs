using HazaraWebApi.Business.src.Dtos;
using HazaraWebApi.Domain.src.Entities;

namespace HazaraWebApi.Business.src.Abstractions;

public interface INewsLetterService : IBaseService<NewsLetter, NewsLetterReadDto, NewsLetterCreateDto, NewsLetterUpdateDto>
{

}
