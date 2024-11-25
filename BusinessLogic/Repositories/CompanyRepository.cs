using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Repositories
{
    public class CompanyRepository : IRepository<Company>
    {
        private readonly AppDbContext dbContext;

        public CompanyRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Add(Company entity)
        {
            await dbContext.Companies.AddAsync(entity);
        }

        public void Delete(Company entity)
        {
            dbContext.Companies.Remove(entity);
        }

        public void Save(Company entity)
        {
            dbContext.Companies.Attach(entity);
        }

        public async Task<Result<List<Company>>> GetAll()
        {
            var companies = await dbContext.Companies
                .AsNoTracking()
                .ToListAsync();

            if (companies is null) return Result.Failure<List<Company>>($"`{nameof(Company)}` не найдено");

            return companies;
        }

        public async Task<Result<Company>> GetById(int id)
        {
            var companies = await dbContext.Companies
                .FirstOrDefaultAsync(e => e.Id == id);

            if (companies is null)
                return Result.Failure<Company>($"`{nameof(Company)}` по заданному Id не найден");

            return Result.Success(companies);
        }
    }
}
