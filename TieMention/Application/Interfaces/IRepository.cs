namespace TieMention.Application.Interfaces;

public interface IRepository<T>
{
    Task<T?> GetByIdAsync(Guid id);
    Task<List<T>> GetAllAsync();
    Task AddAsync(T entity);
}
