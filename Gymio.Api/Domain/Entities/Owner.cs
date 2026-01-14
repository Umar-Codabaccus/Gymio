using Gymio.Api.Domain.Primitives;

namespace Gymio.Api.Domain.Entities
{
    public sealed class Owner : Entity<Guid>
    {
        public Guid UserId { get; private set; }
        public User? User { get; private set; }
    }
}
