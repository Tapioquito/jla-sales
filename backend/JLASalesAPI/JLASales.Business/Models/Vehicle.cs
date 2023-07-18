using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLASales.Business.Models
{
    public class Vehicle : Entity
    {
        public string Name { get; set; }
        public string EnginePower { get; set; }
        public string ReleaseYear { get; set; }
        public string Document { get; set; }


    }
}
