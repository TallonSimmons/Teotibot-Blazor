using Teotibot.Core.Enums;

namespace Teotibot.Core.Entities.Tiles.PyramidTiles
{
    public class ConstructionPyramidTile : PyramidTile
    {
        private const string instructions = @"1. If the bot has 2 or more stone and at least one worker on the
Construction (8) Action Board, it spends 2 stone and places
the leftmost pyramid tile (rotated randomly) onto the top left,
lowest level space available on the Pyramid grid of the Main
Board, and then:
▪ Scores Victory Points for the level.
▪Advances on the Pyramid track.
▪ Scores an additional 2 Victory Points and advances on any
temple by one. (Note: This represents average points the
bot would score by matching icons.)
2. If the above step failed and the bot has at least one worker on
the Stone Quarry (3) Action Board, gain 2 stone.
3. If either of the above steps were successfully performed,
power up a worker on the relevant Action Board (this might
trigger an Ascension, which is resolved normally). Then
advance the powered-up worker (or the new worker, if the old one triggered Ascension).";
        public ConstructionPyramidTile() : base("Construction", TileSet.BaseGame, instructions)
        {
        }
    }
}
