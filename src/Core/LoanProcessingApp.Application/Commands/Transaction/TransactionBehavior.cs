using MediatR;
using System.Windows.Input;

namespace LoanProcessingApp.Application.Commands.Transaction
{
    public class TransactionBehavior<TRequest, TResponse>
    : IPipelineBehavior<TRequest, TResponse>
    where TRequest : ICommand
    {
        private readonly IUnitOfWork _uow;

        public TransactionBehavior(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<TResponse> Handle(
            TRequest request,
            RequestHandlerDelegate<TResponse> next,
            CancellationToken cancellationToken = default)
        {
            await _uow.BeginTransactionAsync(cancellationToken);

            try
            {
                var response = await next();
                await _uow.SaveChangesAsync(cancellationToken);
                return response;
            }
            catch
            {
                await _uow.RollbackChangesAsync(cancellationToken);
                throw;
            }
        }
    }

}
