using Teotibot.Core.Enums;
using Teotibot.Core.ValueObjects;

namespace Teotibot.Core.Entities.PyramidTiles
{
    public class PyramidTile : Tile
    {
        public PyramidTile(string title, TileSet tileSet, string instructions) : base(title, tileSet)
        {
            Instructions = instructions;
        }

        public PyramidPosition PyramidPosition { get; set; }
        public string Instructions { get; }
    }
}
