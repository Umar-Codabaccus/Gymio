using Gymio.Api.Domain.Primitives;

namespace Gymio.Api.Domain.Entities
{
    public sealed class Membership : Entity<Guid>
    {
        private readonly List<Client> _clients = [];

        private Membership() { }

        public Guid GymId { get; private set; }
        public Gym? Gym { get; private set; }
        public string MembershipName { get; private set; } = string.Empty;
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public IReadOnlyCollection<Client> Clients => _clients;
        public static Membership? Create(Guid gymId, string membershipName)
        {
            var membership = new Membership()
            {
                Id = Guid.NewGuid(),
                GymId = gymId,
                MembershipName = membershipName,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            return membership;
        }
    }
}
