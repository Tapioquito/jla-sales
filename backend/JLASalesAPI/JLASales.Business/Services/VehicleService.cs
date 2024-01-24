using JLASales.Business.Interfaces;
using JLASales.Business.Models;
using JLASales.Business.Models.Validations;

namespace JLASales.Business.Services
{
    public class VehicleService : BaseService, IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;
        public VehicleService(IVehicleRepository vehicleRepository,
            INotifier notifier,
            IUnitOfWork unitOfWork) : base(notifier, unitOfWork)
        {
            _vehicleRepository = vehicleRepository;
        }
        public async Task Add(Vehicle vehicle)
        {
            if (!ExecuteValidation(new VehicleValidation(), vehicle)) return;
            var existingVehicle = _vehicleRepository.GetById(vehicle.Id);
            if (existingVehicle != null)
            {
                Notify("já existe um veículo idêntico cadastrado!");
                return;
            }
            _vehicleRepository.Add(vehicle);
            await Commit();
        }
        public async Task Update(Vehicle vehicle)
        {
            if (!ExecuteValidation(new VehicleValidation(), vehicle)) return;
            _vehicleRepository.Update(vehicle);
            await Commit();
        }


        public async Task Remove(Guid id)
        {
            _vehicleRepository.Remove(id);
            await Commit();
        }

        public void Dispose()
        {
            _vehicleRepository?.Dispose();
        }
    }
}
