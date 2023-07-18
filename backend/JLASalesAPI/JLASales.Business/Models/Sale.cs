using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLASales.Business.Models
{
    public class Sale : Entity
    {
        public Guid VendorId { get; set; }//Foreing Key
        public Guid VehicleId { get; set; }//Foreing Key
        public DateTime SaleDate { get; set; }
    }
}
