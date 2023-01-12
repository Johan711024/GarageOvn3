using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageOvn3.Core
{
    public class ParkingLotType
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public double widthOfParkingLot { get; set; }

        //nav prop
        public ICollection<ParkingLot>? ParkingLots { get; set; }
    }
}
