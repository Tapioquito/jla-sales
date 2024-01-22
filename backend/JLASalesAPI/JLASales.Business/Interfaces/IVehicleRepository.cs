using JLASales.Business.Models;

namespace JLASales.Business.Interfaces
{
    public interface IVehicleRepository : IRepository<Vehicle>
    {
        Task<IEnumerable<Vehicle>> GetVehicles();
        //retorna todos os veículos
        Task<Vehicle> GetVehicle(Guid id);
        //retorna um veículo
    }
}
