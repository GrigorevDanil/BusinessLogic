
using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Repositories
{
    public class ProductWarehouseRepository : IProductWarehouseRepository
    {
        private readonly AppDbContext dbContext;

        public ProductWarehouseRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Add(ProductWarehouse entity)
        {
            await dbContext.ProductWarehouses.AddAsync(entity);
        }

        public void Delete(ProductWarehouse entity)
        {
            dbContext.ProductWarehouses.Remove(entity);
        }

        public async Task<Result<List<ProductWarehouse>>> GetAll()
        {
            var productWarehouses = await dbContext.ProductWarehouses
                .AsNoTracking()
                .ToListAsync();

            if (productWarehouses is null) return Result.Failure<List<ProductWarehouse>>($"`{nameof(ProductWarehouse)}` не найдено");

            return productWarehouses;
        }

        public async Task<Result<ProductWarehouse>> GetById(int productId, int warehouseId)
        {
            var productWarehouse = await dbContext.ProductWarehouses
                .FirstOrDefaultAsync(e => e.ProductId == productId && e.WarehouseId == warehouseId);

            if (productWarehouse is null) return Result.Failure<ProductWarehouse>($"`{nameof(ProductWarehouse)}` по заданному Id не найден");

            return productWarehouse;
        }

        public void Save(ProductWarehouse entity)
        {
            dbContext.ProductWarehouses.Attach(entity);
        }
    }
}
