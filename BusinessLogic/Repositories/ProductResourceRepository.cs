
using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Repositories
{
    public class ProductResourceRepository : IProductResourceRepository
    {
        private readonly AppDbContext dbContext;

        public ProductResourceRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Add(ProductResource entity)
        {
            await dbContext.ProductResources.AddAsync(entity);
        }

        public void Delete(ProductResource entity)
        {
            dbContext.ProductResources.Remove(entity);
        }

        public async Task<Result<List<ProductResource>>> GetAll()
        {
            var productResources = await dbContext.ProductResources
                .AsNoTracking()
                .ToListAsync();

            if (productResources is null) return Result.Failure<List<ProductResource>>($"`{nameof(ProductResource)}` не найдено");

            return productResources;
        }

        public async Task<Result<ProductResource>> GetById(int productId, int resourceId)
        {
            var productResource = await dbContext.ProductResources
                .FirstOrDefaultAsync(e => e.ProductId == productId && e.ResourceId == resourceId);

            if (productResource is null) return Result.Failure<ProductResource>($"`{nameof(ProductResource)}` по заданному Id не найден");

            return productResource;
        }

        public void Save(ProductResource entity)
        {
            dbContext.ProductResources.Attach(entity);
        }
    }
}
