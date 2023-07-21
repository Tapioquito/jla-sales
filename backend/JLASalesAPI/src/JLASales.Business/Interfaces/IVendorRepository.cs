using JLASales.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLASales.Business.Interfaces
{
    public interface IVendorRepository : IRepository<Vendor>
    {
        Task<Vendor> GetVendorsAdress(Guid id);
        //Task<Vendor> GetVendorVehiclesAndress(Guid id);
    }
}
