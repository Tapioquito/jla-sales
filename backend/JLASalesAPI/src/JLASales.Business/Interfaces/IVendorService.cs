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
        Task Add(Vendor vendor);
        Task Update(Vendor vendor);
        Task Delete(Vendor vendor);

    }
}
