using Teotibot.Core.Enums;
using Teotibot.Core.ValueObjects;

namespace Teotibot.Core.Entities
{
    public class Tile
    {
        public Tile(string title, TileSet tileSet)
        {
            Image = new TileImage(title, tileSet);
            TileIdentifier = new TileIdentifier(title, tileSet);
            TileSet = tileSet;
        }


        public TileImage Image { get; }
        public TileIdentifier TileIdentifier { get; }
        public TileSet TileSet { get; }
    }
}
