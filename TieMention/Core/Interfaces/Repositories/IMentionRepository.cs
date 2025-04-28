using TieMention.Core.Models;

namespace TieMention.Core.Interfaces.Repositories;

public interface IMentionRepository
{
    // Task<Mention?> GetByIdAsync(Guid id);
    Task<List<Mention>> GetRecentMentionAsync(int page, int pageSize);
    Task AddAsync(Mention mention);
    // Task DeleteAsync(Guid id);
    // Outros métodos conforme necessidade...
}