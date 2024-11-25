using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        private readonly AppDbContext dbContext;

        public ProductRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Add(Product entity)
        {
            await dbContext.Products.AddAsync(entity);
        }

        public void Delete(Product entity)
        {
            dbContext.Products.Remove(entity);
        }

        public void Save(Product entity)
        {
            dbContext.Products.Attach(entity);
        }

        public async Task<Result<List<Product>>> GetAll()
        {
            var products = await dbContext.Products
                .ToListAsync();

            if (products is null) return Result.Failure<List<Product>>($"`{nameof(Product)}` не найдено");

            return products;
        }

        public async Task<Result<Product>> GetById(int id)
        {
            var product = await dbContext.Products
                .Include(e => e.ProductResources)
                .ThenInclude(e => e.Resource)
                .Include(e => e.ProductWarehouses)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (product is null) return Result.Failure<Product>($"`{nameof(Product)}` по заданному Id не найден");

            return Result.Success(product);
        }


    }
}
