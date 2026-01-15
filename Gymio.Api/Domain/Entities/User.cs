namespace Gymio.Api.Domain.Entities
{
    public sealed class User
    {
        private User(string name, string passwordHash)
        {
            Id = Guid.NewGuid();
            Name = name;
            PasswordHash = passwordHash;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        public Guid Id { get; private init; }
        public string Name { get; private set; } = string.Empty;
        public string PasswordHash { get; private set; } = string.Empty;
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public static User? Create(string name, string passwordHash)
        {
            var user = new User(name, passwordHash);
            return user;
        }
    }
}
