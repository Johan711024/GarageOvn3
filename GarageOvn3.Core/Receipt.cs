using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageOvn3.Core
{
    public class Receipt
    {
        // Primary key
        public int Id { get; set; }

        // This is a payload
        public DateTime CheckInTime { get; set; }
        public DateTime? CheckOutTime { get; set;}
        public double Amount { get; set; }
        public string? Currency { get; set; }
        public bool Valid { get; set; }

        // Foreign Keys
        public int VehicleId { get; set; }
        public int ParkingLotId { get; set; }
        public int MembershipId { get; set; }
        
        // Nav props
        public Vehicle? Vehicle { get; set; }
        public ParkingLot? ParkingLot { get; set; }
        public Membership? Membership { get; set; }

    }
}
