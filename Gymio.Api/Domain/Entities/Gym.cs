using Gymio.Api.Domain.Primitives;

namespace Gymio.Api.Domain.Entities
{
    public sealed class Gym : Entity<Guid>
    {
        private Gym(Guid gymId, Guid ownerId, string name, string logoUrl) : base(gymId)
        {
            OwnerId = ownerId;
            Name = name;
            LogoUrl = logoUrl;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        public Guid OwnerId { get; private set; }
        public Owner? Owner { get; private set; }

        public string Name { get; private set; } = string.Empty;
        public string LogoUrl { get; private set; } = string.Empty;
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public List<Membership> Memberships { get; } = new();
        public List<Client> Clients { get; } = new();
        public List<Payment> Payments { get; } = new();

        public static Gym? Create(Guid ownerId, string name, string logoUrl)
        {
            var gymId = Guid.NewGuid();
            var gym = new Gym(gymId, ownerId, name, logoUrl);
            return gym;
        }
    }
}