using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLASales.Business.Models
{

    public class Address : Entity
    {

        public string StreetName { get; set; }

        public string AdditionalInfo { get; set; }
        public string Number { get; set; }

        public string ZipCode { get; set; }


        public string Neighbourhood { get; set; }

        public string City { get; set; }


        public string State { get; set; }

        /*EF Relations: */
        public Vendor Vendor { get; set; }


    }
}
