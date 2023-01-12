using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageOvn3.Core
{
    public class VehicleType
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public double Width { get; set; }

        //nav prop
        public ICollection<Vehicle>? Vehicle { get; set; }

    }
}
