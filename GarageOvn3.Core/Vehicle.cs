using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Xml.Linq;

namespace GarageOvn3.Core
{
    public class Vehicle
    {

        public int Id { get; set; }
        public string RegistrationNr { get; set; } = string.Empty;
        public VehicleColor VehicleColor { get; set; }
        public VehicleBrand VehicleBrand { get; set; } 
        public int Wheels { get; set; }
        public string? VehicleModel { get; set; }

        // Foreign keys
        public int VehicleTypeId { get; set; }
        //public int VehicleOwnerId { get; set; }


        // Navigation properties

        public VehicleType? VehicleType { get; set; }
        //public VehicleOwner? VehicleOwner { get; set; }



        public ICollection<Receipt>? Receipts { get; set; }
        //public ICollection<Membership>? Memberships { get; set; }
        public ICollection<VehicleOwner>? VehicleOwners { get; set; }


    }
}