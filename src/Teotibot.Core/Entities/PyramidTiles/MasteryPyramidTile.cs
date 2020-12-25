using Teotibot.Core.Enums;

namespace Teotibot.Core.Entities.PyramidTiles
{
    public class MasteryPyramidTile : PyramidTile
    {
        private const string instructions = @"1. Find the bot’s highest powered unlocked die.
2. Perform that Action Board’s action if possible:
▪ Forest (2): see step 2 of the Nobles action tile.
▪ Stone Quarry (3): see step 2 of the Construction action tile.
▪ Gold Deposits (4): see step 2 of the Decorations action tile.
▪Alchemy (5): see step 1 of the Alchemy action tile.
▪ Nobles (6): see step 1 of the Nobles action tile.
▪ Decorations (7): see step 1 of the Decorations action tile.
▪Construction (8): see step 1 of the Construction action tile.
3. If the action failed, find the bot’s next highest powered
unlocked worker and repeat step 2 above.
4. If an action succeeds, power up the worker in question (this
might trigger Ascension, which is resolved normally). Then
the bot advances the powered-up worker (or the new worker,
if the old one triggered Ascension).
5. In the extremely unlikely event of all workers failing to
perform an action, the bot gains 5 cocoa instead, powers up
its lowest powered worker, and then advances it.";
        public MasteryPyramidTile() : base("Mastery", TileSet.BaseGame, instructions)
        {
        }
    }
}
