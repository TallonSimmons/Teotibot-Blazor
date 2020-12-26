using Teotibot.Core.Enums;

namespace Teotibot.Core.Entities
{
    public class RoyalTile : Tile
    {
        public RoyalTile(string title, TileSet tileSet, RoyalTileCategory category) : base(title, tileSet, TileType.RoyalTile)
        {
            Category = category;
        }

        public RoyalTileCategory Category { get; }
    }
}
