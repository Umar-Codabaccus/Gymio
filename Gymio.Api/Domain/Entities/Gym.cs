using Gymio.Api.Domain.Primitives;

namespace Gymio.Api.Domain.Entities
{
    public sealed class Gym : Entity<Guid>
    {
        private Gym(Guid ownerId, string name, string logoUrl)
        {
            Id = Guid.NewGuid();
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

        public static Gym? Create(Guid ownerId, string name, string logoUrl)
        {
            var gym = new Gym(ownerId, name, logoUrl);
            return gym;
        }
    }
}
