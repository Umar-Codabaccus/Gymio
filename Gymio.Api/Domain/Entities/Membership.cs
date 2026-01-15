using Gymio.Api.Domain.Primitives;

namespace Gymio.Api.Domain.Entities
{
    public sealed class Membership : Entity<Guid>
    {
        private Membership(string membershipName)
        {
            Id = Guid.NewGuid();
            MembershipName = membershipName;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        public string MembershipName { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public List<Client> Clients { get; }

        public static Membership? Create(string membershipName)
        {
            var membership = new Membership(membershipName);
            return membership;
        }
    }
}
