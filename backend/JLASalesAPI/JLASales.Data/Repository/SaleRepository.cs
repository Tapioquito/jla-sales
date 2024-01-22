using JLASales.Business.Interfaces;
using JLASales.Business.Models;
using JLASales.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace JLASales.Data.Repository
{
    public class SaleRepository : BaseRepository<Sale>, ISaleRepository
    {
        public SaleRepository(JLASalesDBContext context) : base(context)
        {

        }
        public async Task<Sale> GetSaleVendor(Guid id)
        {
            return await Db.Sales
                .AsNoTracking().Include(x => x.Vendor)
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
