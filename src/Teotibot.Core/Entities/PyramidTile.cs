using System.Collections.Generic;
using Teotibot.Core.Enums;
using Teotibot.Core.ValueObjects;

namespace Teotibot.Core.Entities
{
    public class PyramidTile : Tile
    {
        public PyramidTile(string title, TileSet tileSet, string instructions, List<int> triggerNumbers) : base(title, tileSet)
        {
            Trigger = new TileTrigger(triggerNumbers);
            Instructions = instructions;
        }

        public TileTrigger Trigger { get; }
        public PyramidPosition PyramidPosition { get; set; }
        public string Instructions { get; }
    }
}
