using Teotibot.Core.Enums;

namespace Teotibot.Core.Entities.Tiles.PyramidTiles
{
    public class MaskCollectionPyramidTile : PyramidTile
    {
        private const string instructions = @"1. If the bot does not yet have one of the masks available near
one of the Worship actions (on the Palace (1) Action Board
or on any of the 4 temple bands) and it can pay for its cost,
it pays that cost and immediately gains that mask. Draw
a replacement for it immediately, and do not move any dice.
If there are multiple masks it could take, it takes the one with
the lowest number first. If tied between multiple masks of
the same rarity, it picks the first one clockwise, starting from
(and including) the Palace (1) Action Board.
2. If the above step yielded no masks, the bot gains 5 cocoa
instead, powers up its lowest powered worker, and then
advances it.";
        public MaskCollectionPyramidTile() : base("Mask Collection", TileSet.BaseGame, instructions)
        {
        }
    }
}
