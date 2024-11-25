
using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Repositories
{
    public class DistanceRepository : IDistanceRepository
    {
        private readonly AppDbContext dbContext;

        public DistanceRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Add(Distance entity)
        {
            await dbContext.Distances.AddAsync(entity);
        }

        public void Delete(Distance entity)
        {
            dbContext.Distances.Remove(entity);
        }

        public async Task<Result<List<Distance>>> GetAll()
        {
            var distances = await dbContext.Distances
                .AsNoTracking()
                .ToListAsync();

            if (distances is null) return Result.Failure<List<Distance>>($"`{nameof(Distance)}` не найдено");

            return distances;
        }

        public async Task<Result<Distance>> GetById(int shopId, int warehouseId)
        {
            var distance = await dbContext.Distances
               .FirstOrDefaultAsync(e => e.ShopId == shopId && e.WarehouseId == warehouseId);

            if (distance is null) return Result.Failure<Distance>($"`{nameof(Distance)}` по заданному Id не найден");

            return distance;
        }

        public void Save(Distance entity)
        {
            dbContext.Distances.Attach(entity);
        }
    }
}
