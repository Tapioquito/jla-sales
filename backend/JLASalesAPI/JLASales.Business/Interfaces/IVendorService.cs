using JLASales.Business.Models;

namespace JLASales.Business.Interfaces
{
    public interface IVendorService : IDisposable
    {
        Task Add(Vendor vendor);
        Task Update(Vendor vendor);
        Task Remove(Guid id);
    }
}
