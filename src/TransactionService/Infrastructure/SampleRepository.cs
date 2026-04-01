using TransactionService.Core;

namespace TransactionService.Infrastructure
{
    // Infrastructure placeholder
    public class SampleRepository
    {
        public DomainSample Get(int id) => new DomainSample { Id = id, Name = "Sample" };
    }
}
