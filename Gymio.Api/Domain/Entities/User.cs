using Gymio.Api.Domain.Primitives;

namespace Gymio.Api.Domain.Entities
{
    public sealed class User : Entity<Guid>
    {
        private readonly List<Owner> _owners = [];

        private User() { }

        public string Name { get; private set; } = string.Empty;
        public string PasswordHash { get; private set; } = string.Empty;
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public IReadOnlyCollection<Owner> Owners => _owners;

        public static User? Create(string name, string passwordHash)
        {
            var user = new User()
            {
                Id = Guid.NewGuid(),
                Name = name,
                PasswordHash = passwordHash,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            return user;
        }
    }
}
