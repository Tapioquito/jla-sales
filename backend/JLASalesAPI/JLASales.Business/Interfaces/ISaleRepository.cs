using JLASales.Business.Models;

namespace JLASales.Business.Interfaces
{
    public interface ISaleRepository : IRepository<Sale>
    {
        Task<Sale> GetSaleVendor(Guid id);
        //retorna a venda e seu respectivo vendedor

    }
}
