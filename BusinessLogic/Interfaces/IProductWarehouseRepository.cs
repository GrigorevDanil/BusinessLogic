
using BusinessLogic.Entities;
using CSharpFunctionalExtensions;

namespace BusinessLogic.Interfaces
{
    public interface IProductWarehouseRepository
    {
        Task Add(ProductWarehouse entity);
        void Delete(ProductWarehouse entity);
        void Save(ProductWarehouse entity);
        Task<Result<List<ProductWarehouse>>> GetAll();
        Task<Result<ProductWarehouse>> GetById(int productId, int warehouseId);
    }
}
