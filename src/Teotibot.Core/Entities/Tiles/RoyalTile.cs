using Teotibot.Core.Enums;

namespace Teotibot.Core.Entities.Tiles
{
    public class RoyalTile : Tile
    {
        public RoyalTile(string title, Set tileSet, RoyalTileCategory category) : base(title, tileSet, TileType.RoyalTile)
        {
            Category = category;
        }

        public RoyalTileCategory Category { get; }
    }
}
