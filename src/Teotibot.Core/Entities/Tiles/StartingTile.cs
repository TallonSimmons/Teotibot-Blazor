using Teotibot.Core.Enums;

namespace Teotibot.Core.Entities.Tiles
{
    public class StartingTile : Tile
    {
        public StartingTile(string title, Set tileSet) : base(title, tileSet, TileType.StartingTile)
        {
        }
    }
}
