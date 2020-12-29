using Teotibot.Core.Enums;

namespace Teotibot.Core.Entities.Tiles.PyramidTiles
{
    public class WorshipPyramidTile : PyramidTile
    {
        private const string instructions = @"1. Advance the bot’s worker on a Worship space to the next
clockwise Worship space on a temple sidebar (remember:
Teotibot always ignores the Palace (1) Action Board).
▪If there is one of your workers on that space, the bot
unlocks that worker.
▪The bot advances on the matching temple by 2 spaces,
gaining rewards for both (and gaining printed bonuses
instead of Discovery tiles as mentioned before).
▪If the activated space is on the Decorations (7) Action
Board, the bot advances on any temple by 3 instead.
2. Discard the Discovery tile near the activated space, and
immediately draw a replacement for it.";
        public WorshipPyramidTile() : base("Worship", Set.BaseGame, instructions)
        {
        }
    }
}
