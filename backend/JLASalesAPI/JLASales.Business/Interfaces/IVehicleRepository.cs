using JLASales.Business.Models;

namespace JLASales.Business.Interfaces
{
    public interface IVehicleRepository : IRepository<Vehicle>
    {
        Task<IEnumerable<Vehicle>> GetVehiclesVendors();
        //retorna todos os veículos com seus respectivos vendedores
        Task<Vehicle> GetVehicleVendor(Guid id);
        //retorna um veículo com seu respectivo vendedor
    }
}
