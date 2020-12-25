using Teotibot.Core.Enums;

namespace Teotibot.Core.Entities.PyramidTiles
{
    public class DecorationsPyramidTile : PyramidTile
    {
        private const string instructions = @"1. If the bot has 2 or more gold and at least one worker on the
Decorations (7) Action Board, it spends 2 gold and places
the topmost Decoration tile onto an available Decorations
space on the Pyramid grid on the Main Board (clockwise
from the top). Then the bot:
▪ Scores 5 Victory Points.
▪Advances on the Pyramid track.
▪Advances on any temple by one.
2. If the above step failed and the bot has at least one worker on
the Gold Deposits (4) Action Board, gain 2 gold.
3. If either of the above steps were successfully performed,
power up a worker on the relevant Action Board (this might
trigger an Ascension, which is resolved normally). Then
advance the powered-up worker (or the new worker, if the old
one triggered Ascension).
4. If neither of the above steps were successful, the bot gains
5 cocoa instead, powers up its lowest powered worker, and
then advances it.";

        public DecorationsPyramidTile() : base("Decorations", TileSet.BaseGame, instructions)
        {
        }
    }
}
