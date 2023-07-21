using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLASales.Business.Models
{
    public class Vehicle : Entity
    {
        public string ModelName { get; set; }
        public string MotorPower { get; set; }
        public string Document { get; set; }//Renavam
        public string ReleaseYear { get; set; }
        public string Manufacturer { get; set; }
        public string LicensePlate { get; set; }//PLACA
        public double Price { get; set; }

        // EF Relations:





    }
}
