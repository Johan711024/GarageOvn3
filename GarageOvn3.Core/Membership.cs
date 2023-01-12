using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GarageOvn3.Core
{
    public class Membership
    {
        public int Id { get; set; }
        public int SSN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";

        // Foreign Keys       
        public int MembershipTypeId { get; set; }
        // Navigation properties
        public MembershipType? MembershipType { get; set; }

        //public ICollection<VehicleOwner>? VehicleOwners { get; set; }
        //public ICollection<Vehicle>? Vehicles { get; set; }
        public ICollection<Receipt>? Receipts { get; set; }
    }
}
