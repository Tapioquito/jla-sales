using JLASales.Business.Models;

namespace JLASales.Business.Interfaces
{
    public interface IAddressRepository : IRepository<Address>
    {
        Task<Address> GetAddressByVendor(Guid vendorId);
    }
}
