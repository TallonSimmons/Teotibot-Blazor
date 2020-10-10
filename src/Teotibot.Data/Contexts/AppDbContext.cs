using Microsoft.EntityFrameworkCore;
using Teotibot.Core.DataModels;

namespace Teotibot.Data.Contexts
{
    internal class AppDbContext : DbContext
    {
        internal DbSet<StartingTileData> StartingTiles { get; set; }
        internal DbSet<PyramidTileData> PyramidTiles { get; set; }
        internal DbSet<TechnologyTileData> TechnologyTiles { get; set; }
        internal DbSet<RoyalTileData> RoyalTiles { get; set; }
        internal DbSet<TempleBonusTileData> TempleTiles { get; set; }
    }
}
