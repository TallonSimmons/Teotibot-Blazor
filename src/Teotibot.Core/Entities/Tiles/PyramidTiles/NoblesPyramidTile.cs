using System;
using System.Collections.Generic;
using System.Text;
using Teotibot.Core.Enums;

namespace Teotibot.Core.Entities.Tiles.PyramidTiles
{
    public class NoblesPyramidTile : PyramidTile
    {
        private const string instructions = @"1. If the bot has at least 2 wood and one worker on the Nobles (6)
Action Board, it spends 2 wood and builds a Building.
▪ Before the first Eclipse, place it in the first (top) row.
▪After the first Eclipse (but before the second), place it in the
second (centre) row.
▪After the second Eclipse, place it in the third (bottom) row.
▪If a row is full, place it into a space with the lowest printed
Victory Point value of all three rows.
▪ Score the Victory Points shown on the space just covered,
and advance the bot on the Avenue of the Dead (the same
way an actual player would advance).
2. If the above step failed and the bot has at least one worker on
the Forest (2) Action Board, it gains 2 wood.
3. If either of the above steps were successfully performed, the
bot powers up a worker on the relevant Action Board (this
might trigger Ascension, which is resolved normally). Then
the bot advances the powered-up worker (or the new worker,
if the old one triggered Ascension).
4. If neither of the above steps were successful, the bot gains
5 cocoa instead, powers up its lowest powered worker, and
then advances it.";
        public NoblesPyramidTile() : base("Nobles", TileSet.BaseGame, instructions)
        {
        }
    }
}
