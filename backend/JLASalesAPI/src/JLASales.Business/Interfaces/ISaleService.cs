using JLASales.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLASales.Business.Interfaces
{
    public interface ISaleService :IDisposable
    {
        Task Add(Sale sale);
        Task Update(Sale sale);
        Task Delete(Sale sale);
    }
}
