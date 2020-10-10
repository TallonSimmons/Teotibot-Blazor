using Teotibot.Core.Enums;
using Teotibot.Core.ValueObjects;

namespace Teotibot.Core.Entities
{
    public class Tile
    {
        public Tile(string path, string title, TileSet tileSet)
        {
            Image = new TileImage(path);
            TileIdentifier = new TileIdentifier(title, tileSet);
            TileSet = tileSet;
        }


        public TileImage Image { get; }
        public TileIdentifier TileIdentifier { get; }
        public TileSet TileSet { get; }
    }
}
