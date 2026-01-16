using Gymio.Api.Domain.Primitives;

namespace Gymio.Api.Domain.Entities
{
    public sealed class Gym : Entity<Guid>
    {
        private readonly List<Membership> _memberships = [];
        private readonly List<Client> _clients = [];
        private readonly List<Payment> _payments = [];

        private Gym() { }

        public Guid OwnerId { get; private set; }
        public Owner? Owner { get; private set; }

        public string Name { get; private set; } = string.Empty;
        public string LogoUrl { get; private set; } = string.Empty;
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public IReadOnlyCollection<Membership> Memberships => _memberships;
        public IReadOnlyCollection<Client> Clients => _clients;
        public IReadOnlyCollection<Payment> Payments => _payments;

        public static Gym? Create(Guid ownerId, string name, string logoUrl)
        {
            var gym = new Gym()
            {
                Id = Guid.NewGuid(),
                OwnerId = ownerId,
                Name = name,
                LogoUrl = logoUrl,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            return gym;
        }
    }
}