using JLASales.Business.Interfaces;
using JLASales.Business.Models;
using JLASales.Business.Valdations;
namespace JLASales.Business.Services
{
    public class VendorService : BaseService, IVendorService
    {

        private readonly IVendorRepository _vendorRepository;
        private readonly IAddressRepository _addressRepository;
        public VendorService(IVendorRepository vendorRepository,
                            IAddressRepository addressRepository,
                            INotifier notifier)
            : base(notifier)
        {
            _vendorRepository = vendorRepository;
            _addressRepository = addressRepository;

        }

        public async Task<bool> Add(Vendor vendor)
        {
            if (!ExecuteValidation(new VendorValidation(), vendor)
                || ExecuteValidation(new AddressValidation(), vendor.Address)) return false;

            if (_vendorRepository.Search(v => v.Document == vendor.Document).Result.Any())
            {
                Notify("Já existe um vendedor com este documento informado!");
                return false;
            }
            await _vendorRepository.Add(vendor);
            return true;
        }
        public async Task<bool> Update(Vendor vendor)
        {
            if (!ExecuteValidation(new VendorValidation(), vendor)) return false;

            if (_vendorRepository.Search(v => v.Document == vendor.Document).Result.Any())
            {

                Notify("Já existe um vendedor com este documento informado!");
                return false;
            }
            await _vendorRepository.Update(vendor);
            return true;

        }
        public async Task<bool> Delete(Guid id)
        {
            if (_vendorRepository.GetVendorSalesAndress(id).Result.Sales.Any())
            {

                Notify("O vendedor possui vendas cadastradas!");
                return false;
            }

            var address = await _addressRepository.GetAddressByVendor(id);
            if (address != null)
            {
                await _addressRepository.DeleteById(address.Id);
            }
            await _vendorRepository.DeleteById(id);
            return true;
        }
        public async Task UpdateAddress(Address address)
        {
            if (!ExecuteValidation(new AddressValidation(), address)) return;
            await _addressRepository.Update(address);

        }
        public void Dispose()
        {
            _vendorRepository?.Dispose();
            _addressRepository?.Dispose();
        }
    }
}
