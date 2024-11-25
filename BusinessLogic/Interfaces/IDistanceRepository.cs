
using BusinessLogic.Entities;
using CSharpFunctionalExtensions;

namespace BusinessLogic.Interfaces
{
    public interface IDistanceRepository
    {
        Task Add(Distance entity);
        void Delete(Distance entity);
        void Save(Distance entity);
        Task<Result<List<Distance>>> GetAll();
        Task<Result<Distance>> GetById(int shopId, int warehouseId);
    }
}
