using Gymio.Api.Domain.Primitives;

namespace Gymio.Api.Domain.Entities
{
    public sealed class Membership : Entity<Guid>
    {
        private Membership(Guid membershipId, Guid gymId, string membershipName) : base(membershipId)
        {
            GymId = gymId;
            MembershipName = membershipName;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        public Guid GymId { get; private set; }
        public Gym? Gym { get; private set; }
        public string MembershipName { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public List<Client> Clients { get; } = new();

        public static Membership? Create(Guid gymId, string membershipName)
        {
            var membershipId = Guid.NewGuid();
            var membership = new Membership(membershipId, gymId, membershipName);
            return membership;
        }
    }
}
