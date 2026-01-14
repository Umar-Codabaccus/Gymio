using Gymio.Api.Domain.Primitives;

namespace Gymio.Api.Domain.Entities
{
    public sealed class Owner : Entity<Guid>
    {
        private Owner(Guid userId)
        {
            UserId = userId;
        }
        public Guid UserId { get; private set; }
        public User? User { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public static Owner? Create(Guid userId)
        {
            var owner = new Owner(userId);
            return owner;
        }
    }
}
