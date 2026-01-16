using Microsoft.EntityFrameworkCore;

using Gymio.Api.Domain.Entities;

namespace Gymio.Api.Database;

public class GymioDbContext : DbContext
{
    public GymioDbContext(DbContextOptions<GymioDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Owner> Owners { get; set; }
    public DbSet<Gym> Gyms { get; set; }
    public DbSet<Membership> Memberships { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Payment> Payments { get; set; }
}