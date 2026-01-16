namespace Gymio.Api.Domain.Primitives
{
    public abstract class Entity<Guid> : IEquatable<Entity<Guid>>
    {
        public Guid Id { get; protected init; }

        protected Entity(Guid id)
        {
            Id = id;
        }

        public bool Equals(Entity<Guid>? other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return EqualityComparer<Guid>.Default.Equals(Id, other.Id);
        }

        public override bool Equals(object? obj)
        {
            return obj is Entity<Guid> other && Equals(other);
        }

        public override int GetHashCode()
        {
            return EqualityComparer<Guid>.Default.GetHashCode(Id);
        }
    }
}
