using JLASales.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLASales.Business.Interfaces
{
    public interface IVendorService : IDisposable
    {
        Task<bool> Add(Vendor vendor);
        Task<bool> Update(Vendor vendor);
        Task<bool> Delete(Guid id);

        Task UpdateAddress(Address address);
    }
}
