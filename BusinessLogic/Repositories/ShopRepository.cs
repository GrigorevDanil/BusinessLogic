using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Repositories
{
    public class ShopRepository : IRepository<Shop>
    {
        private readonly AppDbContext dbContext;

        public ShopRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Add(Shop entity)
        {
            await dbContext.AddAsync(entity);
        }

        public void Delete(Shop entity)
        {
            dbContext.Remove(entity);
        }

        public void Save(Shop entity)
        {
            dbContext.Attach(entity);
        }

        public async Task<Result<List<Shop>>> GetAll()
        {
            var shops = await dbContext.Shops
                .AsNoTracking()
                .ToListAsync();

            if (shops is null) return Result.Failure<List<Shop>>($"`{nameof(Shop)}` не найдено");

            return shops;
        }

        public async Task<Result<Shop>> GetById(int id)
        {
            var shop = await dbContext.Shops
                .Include(e => e.Distances)
                .ThenInclude(e => e.Warehouse)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (shop is null) return Result.Failure<Shop>($"`{nameof(Shop)}` по заданному Id не найден");

            return Result.Success(shop);
        }


    }
}
