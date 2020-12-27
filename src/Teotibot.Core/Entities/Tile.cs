using Teotibot.Core.Enums;
using Teotibot.Core.ValueObjects;

namespace Teotibot.Core.Entities
{
    public class Tile
    {
        public Tile(string title, TileSet tileSet, TileType tileType)
        {
            Image = new TileImage(title, tileSet, tileType);
            TileIdentifier = new TileIdentifier(title, tileSet);
            TileSet = tileSet;
            TileType = tileType;
        }


        public TileImage Image { get; }
        public TileIdentifier TileIdentifier { get; }
        public TileSet TileSet { get; }
        public TileType TileType { get; }
    }
}
