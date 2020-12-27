using Teotibot.Core.Enums;

namespace Teotibot.Core.Entities.Tiles.PyramidTiles
{
    public class AlchemyPyramidTile : PyramidTile
    {
        private const string instructions = @"1. If the bot has 1 or more gold and at least one worker on the
Alchemy (5) Action Board, it spends 1 gold and then gains
the Technology of the lowest number that does not have any
markers (yours or Teotibot’s).
▪If all remaining tiles have your marker on, then the bot
gains the lowest numbered Technology which it does not
yet have, while you score the 3 Victory Points as normal.
▪ Either way, advance on the temple matching the gained
Technology and power up a worker on this Action Board
(this might trigger an Ascension, which is resolved
normally). Then the bot advances the powered-up worker
(or the new worker, if the old one triggered Ascension).
Note: the bot does not benefit from Technology tiles.
2. If the above step failed, power up its lowest unlocked worker
by two, without carrying out any actions or advancing any
workers.";
        public AlchemyPyramidTile() : base("Alchemy", TileSet.BaseGame, instructions)
        {
        }
    }
}
