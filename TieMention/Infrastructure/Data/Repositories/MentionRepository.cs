using TieMention.Core.Interfaces.Repositories;
using TieMention.Core.Models;
using TieMention.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace TieMention.Infrastructure.Data.Repositories;

public class MentionRepository : IMentionRepository
{
    private readonly AppDbContext _dbContext;

    public MentionRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    // public async Task<Mention?> GetByIdAsync(Guid id)
    // {
    //     return await _dbContext.Mention
    //         .Include(p => p.Comments) // Exemplo: Carrega comments eager loading
    //         .FirstOrDefaultAsync(p => p.Id == id);
    // }

    public async Task<List<Mention>> GetRecentMentionAsync(int page, int pageSize)
    {
        return await _dbContext.Mention
            .OrderByDescending(p => p.CreatedAt)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task AddAsync(Mention Mention)
    {
        await _dbContext.Mention.AddAsync(Mention);
        await _dbContext.SaveChangesAsync();
    }

    // public async Task DeleteAsync(Guid id)
    // {
    //     var Mention = await GetByIdAsync(id);
    //     if (Mention != null)
    //     {
    //         _dbContext.Mention.Remove(Mention);
    //         await _dbContext.SaveChangesAsync();
    //     }
    // }
}