using Microsoft.EntityFrameworkCore;

namespace BaskTalents.Models;

public class PlayerContext : DbContext
{
    public PlayerContext(DbContextOptions<PlayerContext> options)
        : base(options)
    {
    }

    public DbSet<PlayerModel> PlayerModel { get; set; } = null!;
}

