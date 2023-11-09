using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLASales.Business.Models
{
    public class Vendor : Entity
    {

        public string Name { get; set; }

        public string Document { get; set; }

        public Address Address { get; set; }

        public bool ActiveFlag { get; set; }

        /* EF Relations: */

        public IEnumerable<Sale> Sales { get; set; }
    }
}
