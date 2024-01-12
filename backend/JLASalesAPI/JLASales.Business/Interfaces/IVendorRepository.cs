using JLASales.Business.Models;

namespace JLASales.Business.Interfaces
{
    public interface IVendorRepository : IRepository<Vendor>
    {
        Task<Vendor> GetVendorAddress(Guid id);
        //retorna um vendedor e seu respectivo endereço
        Task<Vendor> GetVendorSalesAddress(Guid id);
        //retorna o vendedor, TODAS AS VENDAS e o seu endereço
        Task<Address> GetAddressByVendor(Guid vendorId);
        //retorna apenas o endereço através do id do fornecedor
        void RemoveAddressVendor(Address address);
    }
}
