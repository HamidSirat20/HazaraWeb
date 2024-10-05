using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HazaraWebApi.Business.src.Dtos;
using HazaraWebApi.Domain.src.Entities;

namespace HazaraWebApi.Business.src.Abstractions;

public interface IArticleService :
IBaseService<Article, ArticleReadDto, ArticleCreateDto, ArticleUpdateDto>
{

}
