using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Repositories
{
    public class SaleRepository : IRepository<Sale>
    {
        private readonly AppDbContext dbContext;

        public SaleRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Add(Sale entity)
        {
            await dbContext.AddAsync(entity);
        }

        public void Delete(Sale entity)
        {
            dbContext.Remove(entity);
        }

        public void Save(Sale entity)
        {
            dbContext.Attach(entity);
        }

        public async Task<Result<List<Sale>>> GetAll()
        {
            var sales = await dbContext.Sales
                .AsNoTracking()
                .ToListAsync();

            if (sales is null) return Result.Failure<List<Sale>>($"`{nameof(Sale)}` не найдено");

            return sales;
        }

        public async Task<Result<Sale>> GetById(int id)
        {
            var sales = await dbContext.Sales
                .FirstOrDefaultAsync(e => e.Id == id);

            if (sales is null) return Result.Failure<Sale>($"`{nameof(Sale)}` по заданному Id не найден");

            return Result.Success(sales);
        }


    }
}
