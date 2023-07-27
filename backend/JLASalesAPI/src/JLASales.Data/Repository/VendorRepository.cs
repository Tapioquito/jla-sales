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
    public class VendorRepository : Repository<Vendor>, IVendorRepository
    {
        public VendorRepository(JLASalesDbContext db) : base(db)
        {
        }

        public async Task<Vendor> GetVendorsAdress(Guid id)
        {
            return await Db.Vendors.AsNoTracking()
                   .Include(c => c.Address)
                   .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Vendor> GetVendorSalesAndress(Guid id)
        {
            return await Db.Vendors.AsNoTracking()
                .Include(c => c.Sales)
                .Include(c => c.Address)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

    }
}
