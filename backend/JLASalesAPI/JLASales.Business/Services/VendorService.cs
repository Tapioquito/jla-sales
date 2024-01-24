using JLASales.Business.Interfaces;
using JLASales.Business.Models;
using JLASales.Business.Models.Validations;
using System.Numerics;

namespace JLASales.Business.Services
{
    public class VendorService : BaseService, IVendorService
    {
        private readonly IVendorRepository _vendorRepository;
        public VendorService(IVendorRepository vendorRepository, INotifier notifier, IUnitOfWork unitOfWork)
            : base(notifier, unitOfWork)
        {
            _vendorRepository = vendorRepository;
        }

        public async Task Add(Vendor vendor)
        {
            if (!ExecuteValidation(new VendorValidation(), vendor)) return;
            var existingVendor = _vendorRepository.GetById(vendor.Id);
            if (existingVendor != null)
            {
                Notify("Já existe um vendedor com este id informado.");
                return;
            }
            _vendorRepository.Add(vendor);
            await Commit();
        }
        public async Task Update(Vendor vendor)
        {
            if (!ExecuteValidation(new VendorValidation(), vendor)) return;
            _vendorRepository.Update(vendor);
            await Commit();
        }
        public async Task Remove(Guid id)
        {
            var existingVendor = _vendorRepository.GetById(id);
            if (existingVendor == null)
            {
                Notify("Não foi localizado um vendedor com este id"); return;
            }
            _vendorRepository.Remove(id);
            await Commit();
        }
        public void Dispose()
        {
            _vendorRepository?.Dispose();
        }

    }
}
