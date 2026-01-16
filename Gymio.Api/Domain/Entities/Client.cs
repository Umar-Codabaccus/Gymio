using Gymio.Api.Domain.Primitives;

namespace Gymio.Api.Domain.Entities
{
    public sealed class Client : Entity<Guid>
    {
        private readonly List<Payment> _payments = [];

        private Client() { }

        public Guid GymId { get; private set; }
        public Gym? Gym { get; private set; }
        public Guid MembershipId { get; private set; }
        public Membership? Membership { get; private set; }

        public string Name { get; private set; } = string.Empty;
        public string? Phone { get; private set; } = string.Empty;
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public IReadOnlyCollection<Payment> Payments => _payments;

        public static Client? Create(Guid gymId, Guid membershipId, string name, string phone)
        {
            var client = new Client()
            {
                Id = Guid.NewGuid(),
                GymId = gymId,
                MembershipId = membershipId,
                Name = name,
                Phone = phone,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };

            return client;
        }
    }
}
