namespace FDM.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}