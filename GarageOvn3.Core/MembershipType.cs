namespace GarageOvn3.Core
{
    public class MembershipType
    {
        public int Id { get; set; }
        public string? Description { get; set; }

        public ICollection<Membership>? Memberships { get; set; }
    }
}