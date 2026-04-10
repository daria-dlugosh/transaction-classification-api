using TransactionClassificationApp.TransactionService.Core.Interfaces;

namespace TransactionClassificationApp.TransactionService.Infrastructure.Repositories;

public class TransactionRepository : ITransactionRepository
{
    public Task CreateAsync(object transaction)
    {
        // TODO: Implement - save to database
        throw new NotImplementedException();
    }

    public Task<object?> GetByIdAsync(int id)
    {
        // TODO: Implement - retrieve from database
        throw new NotImplementedException();
    }

    public Task<IEnumerable<object>> GetAllAsync()
    {
        // TODO: Implement - retrieve all from database
        throw new NotImplementedException();
    }
}
