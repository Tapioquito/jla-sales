using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLASales.Domain.Entities
{
    public class Sale : Entity
    {
        public Guid VendorId { get; set; }
        public Guid VehicleId { get; set; }
        public double SaleValue { get; set; }
        public DateTime SaleDate { get; set; } = DateTime.Now;

        //EF Relations:
        public Vendor Vendor { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
