using Gymio.Api.Domain.Primitives;

namespace Gymio.Api.Domain.Entities
{
    public sealed class Owner : Entity<Guid>
    {
        private Owner(Guid ownerId, Guid userId) : base(ownerId)
        {
            UserId = userId;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        public Guid UserId { get; private set; }
        public User? User { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public static Owner? Create(Guid userId)
        {
            var ownerId = Guid.NewGuid();
            var owner = new Owner(ownerId, userId);
            return owner;
        }
    }
}
