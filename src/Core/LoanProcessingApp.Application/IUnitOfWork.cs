namespace LoanProcessingApp.Application
{
    public interface IUnitOfWork
    {
        Task BeginTransactionAsync(CancellationToken cancellationToken = default);
        Task SaveChangesAsync(CancellationToken cancellationToken = default);
        Task RollbackChangesAsync(CancellationToken cancellationToken = default);
    }
}
