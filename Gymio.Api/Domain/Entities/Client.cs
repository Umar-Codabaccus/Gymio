using Gymio.Api.Domain.Primitives;

namespace Gymio.Api.Domain.Entities
{
    public sealed class Client : Entity<Guid>
    {
        private Client(Guid gymId, string name, string phone)
        {
            Id = Guid.NewGuid();
            GymId = gymId;
            Name = name;
            Phone = phone;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        public Guid GymId { get; private set; }
        public Gym? Gym { get; private set; }

        public string Name { get; private set; } = string.Empty;
        public string Phone { get; private set; } = string.Empty;
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public static Client? Create(Guid gymId, string name, string phone)
        {
            var client = new Client(gymId, name, phone);
            return client;
        }
    }
}
