using JLASales.Business.Interfaces;
using JLASales.Business.Models;
using JLASales.Business.Models.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLASales.Business.Services
{
    public class VehicleService : BaseService, IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;
        public VehicleService(IVehicleRepository vehicleRepository, INotifier notifier) : base(notifier)
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
            await _vehicleRepository.Add(vehicle);
        }
        public async Task Update(Vehicle vehicle)
        {
            if (!ExecuteValidation(new VehicleValidation(), vehicle)) return;
            await _vehicleRepository.Update(vehicle);
        }


        public async Task Remove(Guid id)
        {
            await _vehicleRepository.Remove(id);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
