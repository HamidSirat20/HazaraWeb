using HazaraWebApi.Domain.src.Shared;

namespace HazaraWebApi.Domain.src.Abstractions;

public interface IBaseRepo<T>
{
    Task<IEnumerable<T>> GetAll(QueryParameters queryParameters);
    Task<T> GetOneById(Guid id);
    Task<T> UpdateOneById(T newEntity);
    Task<bool> DeleteOneById(T newEntity);
    Task<T> CreateOne(T newEntity);
}
