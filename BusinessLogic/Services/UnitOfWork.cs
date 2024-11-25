
using BusinessLogic.Interfaces;

namespace BusinessLogic.Services;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _dbContext;

    public UnitOfWork(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task SaveChanges()
    {
        await _dbContext.SaveChangesAsync();
    }
}