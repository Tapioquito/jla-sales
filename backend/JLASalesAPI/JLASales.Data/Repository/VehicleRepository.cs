using JLASales.Business.Interfaces;
using JLASales.Business.Models;
using JLASales.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLASales.Data.Repository
{
    public class VehicleRepository : BaseRepository<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(JLASalesDBContext context) : base(context)
        {

        }


        public async Task<IEnumerable<Vehicle>> GetVehicles()
        {
            return await Db.Vehicles
                .AsNoTracking().OrderBy(x => x.ReleaseYear)
                .ToListAsync();
        }

        public async Task<Vehicle> GetVehicle(Guid id)
        {
            return await Db.Vehicles?.
                   AsNoTracking()
                   .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
