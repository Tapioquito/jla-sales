using JLASales.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLASales.Business.Interfaces
{
    public interface ISaleRepository : IRepository<Sale>
    {
        Task<IEnumerable<Sale>> GetSalesByVendor(Guid vendorId);
        Task<Sale> GetSaleByVehicle(Guid vehicleId);

        Task<IEnumerable<Sale>> GetAllSales();

    }
}
