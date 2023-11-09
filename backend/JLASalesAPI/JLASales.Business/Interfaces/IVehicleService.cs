using JLASales.Business.Models;

namespace JLASales.Business.Interfaces
{
    public interface IVehicleService : IDisposable
    {
        Task Add(Vehicle vehicle);
        Task Update(Vehicle vehicle);
        Task Remove(Guid id);
    }
}
