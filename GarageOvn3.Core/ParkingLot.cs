using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageOvn3.Core
{
    public class ParkingLot
    {
        public int Id { get; set; }
        
        // Foreign Keys       
        public int ParkingLotTypeId { get; set; }
        // Navigation properties
        public ParkingLotType? ParkingLotType { get; set; }

    }
}
