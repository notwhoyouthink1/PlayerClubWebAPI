using Microsoft.EntityFrameworkCore;

namespace PlayerClubWebAPI.Models
{
    public class PlayerClubContext : DbContext
    {
        public PlayerClubContext(DbContextOptions<PlayerClubContext> options) : base(options)
        {
        }

        public DbSet<Team> Teams { get; set; } = null!;
        public DbSet<Player> Players { get; set; } = null!;
    }
}
