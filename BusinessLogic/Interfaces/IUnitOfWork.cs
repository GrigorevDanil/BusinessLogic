namespace BusinessLogic.Interfaces
{
    public interface IUnitOfWork
    {
        Task SaveChanges();
    }
}