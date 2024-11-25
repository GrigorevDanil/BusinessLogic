using CSharpFunctionalExtensions;

namespace BusinessLogic.Interfaces
{
    public interface IRepository<T>
    {
        Task Add(T entity);
        void Delete(T entity);
        void Save(T entity);
        Task<Result<List<T>>> GetAll();
        Task<Result<T>> GetById(int id);
    }
}
