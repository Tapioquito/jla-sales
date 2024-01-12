using JLASales.Business.Models;

namespace JLASales.Business.Interfaces
{
    public interface ISaleService : IDisposable
    {
        Task Add(Sale sale);
        Task Update(Sale sale);
        Task Remove(Guid id);
    }
}
