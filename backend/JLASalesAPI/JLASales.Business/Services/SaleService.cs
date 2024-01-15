using JLASales.Business.Interfaces;
using JLASales.Business.Models;
using JLASales.Business.Models.Validations;

namespace JLASales.Business.Services
{
    public class SaleService : BaseService, ISaleService
    {
        private readonly ISaleRepository _saleRepository;
        public SaleService(INotifier notifier,
                           IUnitOfWork unitOfWork,
                           ISaleRepository saleRepository) : base(notifier, unitOfWork)
        {
            _saleRepository = saleRepository;
        }

        public async Task Add(Sale sale)
        {
            if (!ExecuteValidation(new SaleValidation(), sale)) return;
            var existingSale = _saleRepository.GetById(sale.Id);
            if (existingSale != null)
            {
                Notify("Já existe uma venda com este mesmo id!");
                return;
            }
            await _saleRepository.Add(sale);
            await Commit();
        }
        public async Task Update(Sale sale)
        {
            if (!ExecuteValidation(new SaleValidation(), sale)) return;
            await _saleRepository.Update(sale);
            await Commit();
        }


        public async Task Remove(Guid id)
        {
            var sale = await _saleRepository.GetById(id);
            if (sale == null)
            {
                Notify("Não foi localizado uma venda com este id"); return;
            }
            await _saleRepository.Remove(id);
            await Commit();

        }

        public void Dispose()
        {
            _saleRepository?.Dispose();
        }
    }
}
