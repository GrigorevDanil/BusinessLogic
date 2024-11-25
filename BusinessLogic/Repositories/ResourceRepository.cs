using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Repositories
{
    public class ResourceRepository : IRepository<Resource>
    {
        private readonly AppDbContext dbContext;

        public ResourceRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Add(Resource entity)
        {
            await dbContext.Resources.AddAsync(entity);
        }

        public void Delete(Resource entity)
        {
            dbContext.Resources.Remove(entity);
        }

        public void Save(Resource entity)
        {
            dbContext.Resources.Attach(entity);

        }

        public async Task<Result<List<Resource>>> GetAll()
        {
            var resources = await dbContext.Resources
                .ToListAsync();

            if (resources is null) return Result.Failure<List<Resource>>($"`{nameof(Resource)}` не найдено");

            return resources;
        }

        public async Task<Result<Resource>> GetById(int id)
        {
            var resource = await dbContext.Resources
                .Include(e => e.ProductResources)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (resource is null) return Result.Failure<Resource>($"`{nameof(Resource)}` по заданному Id не найден");

            return Result.Success(resource);
        }


    }
}
