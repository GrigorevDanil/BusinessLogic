
using BusinessLogic.Entities;
using CSharpFunctionalExtensions;

namespace BusinessLogic.Interfaces
{
    public interface IProductResourceRepository
    {
        Task Add(ProductResource entity);
        void Delete(ProductResource entity);
        void Save(ProductResource entity);
        Task<Result<List<ProductResource>>> GetAll();
        Task<Result<ProductResource>> GetById(int productId, int resourceId);
    }
}
