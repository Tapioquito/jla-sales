using JLASales.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLASales.Business.Interfaces
{
    public  interface IVehicleService : IDisposable
    {
        Task Add(Vehicle vehicle);
        Task Update(Vehicle vehicle);
        Task Delete(Vehicle vehicle);
    }
}
