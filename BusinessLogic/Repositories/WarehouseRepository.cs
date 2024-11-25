using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Repositories
{
    public class WarehouseRepository : IRepository<Warehouse>
    {
        private readonly AppDbContext dbContext;

        public WarehouseRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Add(Warehouse entity)
        {
            await dbContext.Warehouses.AddAsync(entity);
        }

        public void Delete(Warehouse entity)
        {
            dbContext.Warehouses.Remove(entity);
        }

        public void Save(Warehouse entity)
        {
            dbContext.Warehouses.Attach(entity);
        }

        public async Task<Result<List<Warehouse>>> GetAll()
        {
            var warehouses = await dbContext.Warehouses.ToListAsync();

            if (warehouses is null) return Result.Failure<List<Warehouse>>($"`{nameof(Warehouse)}` не найдено");

            return warehouses;
        }

        public async Task<Result<Warehouse>> GetById(int id)
        {
            var warehouse = await dbContext.Warehouses
                .Include(e => e.ProductWarehouses)
                .ThenInclude(e => e.Product)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (warehouse is null) return Result.Failure<Warehouse>($"`{nameof(Warehouse)}` по заданному Id не найден");

            return Result.Success(warehouse);
        }


    }
}
