using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Repositories
{
    public class InvestmentRepository : IRepository<Investment>
    {
        private readonly AppDbContext dbContext;

        public InvestmentRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Add(Investment entity)
        {
            await dbContext.Investments.AddAsync(entity);
        }

        public void Delete(Investment entity)
        {
            dbContext.Investments.Remove(entity);
        }

        public async Task<Result<List<Investment>>> GetAll()
        {
            var investments = await dbContext.Investments
                .Include(e => e.Company)
                .AsNoTracking()
                .ToListAsync();

            if (investments is null) return Result.Failure<List<Investment>>($"`{nameof(Investment)}` не найдено");

            return investments;
        }

        public async Task<Result<Investment>> GetById(int id)
        {
            var investment = await dbContext.Investments
                .Include(e => e.Company)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (investment is null)
                return Result.Failure<Investment>($"`{nameof(Investment)}` по заданному Id не найден");

            return Result.Success(investment);
        }

        public void Save(Investment entity)
        {
            dbContext.Investments.Attach(entity);
        }
    }
}
