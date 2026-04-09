namespace TransactionClassificationApp.TransactionService.Core.Interfaces;

public interface ITransactionRepository
{
    Task CreateAsync(object transaction);
    Task<object?> GetByIdAsync(int id);
    Task<IEnumerable<object>> GetAllAsync();
}