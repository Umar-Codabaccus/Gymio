using Gymio.Api.Domain.Primitives;

namespace Gymio.Api.Domain.Entities
{
    public sealed class User : Entity<Guid>
    {
        private User(Guid userId, string name, string passwordHash) : base(userId)
        {
            Name = name;
            PasswordHash = passwordHash;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        public string Name { get; private set; } = string.Empty;
        public string PasswordHash { get; private set; } = string.Empty;
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public List<Owner> Owners { get; } = new();

        public static User? Create(string name, string passwordHash)
        {
            var userId = Guid.NewGuid();    
            var user = new User(userId,name, passwordHash);
            return user;
        }
    }
}
