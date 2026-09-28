using LoanProcessingApp.Application;
using LoanProcessingApp.Infrastructure.Context;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace LoanProcessingApp.Database
{
    public class CustomerInfoRepository:IUnitOfWork
    {
        private readonly LoanAppContext _context;
        private IDbContextTransaction? _transaction;
        public CustomerInfoRepository(LoanAppContext context)
        {
            _context = context;
        }
        public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await _context.SaveChangesAsync(cancellationToken); 
            await _transaction!.CommitAsync(cancellationToken);
        }
        public async Task BeginTransactionAsync(CancellationToken cancellationToken = default)
        {
            _transaction = await _context.Database.BeginTransactionAsync(cancellationToken);
        }
        public async Task RollbackChangesAsync(CancellationToken cancellationToken = default)
        {
            await _transaction!.RollbackAsync(cancellationToken);
        }
    }
}
