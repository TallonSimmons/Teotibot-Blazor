using System.Collections.Generic;
using Teotibot.Core.Entities.Tiles.PyramidTiles;
using Teotibot.Core.Enums;
using Teotibot.Core.ValueObjects.Settings;

namespace Teotibot.Core.UnitTests.Entities.GameTests
{
    public class GameTestFixture
    {
        public readonly IEnumerable<PyramidTile> Tiles = new List<PyramidTile>
        {
            new PyramidTile("Test", Set.BaseGame, "instructions"),
            new PyramidTile("Test", Set.BaseGame, "instructions"),
            new PyramidTile("Test", Set.BaseGame, "instructions"),
            new PyramidTile("Test", Set.BaseGame, "instructions"),
            new PyramidTile("Test", Set.BaseGame, "instructions"),
            new PyramidTile("Test", Set.BaseGame, "instructions"),
        };

        public readonly GameSettings EverythingOnGameSettings =
            new GameSettings
            (
                new LatePreClassicPeriodSettings(true, true),
                new ShadowsOfXitleSettings(true, true),
                new PromoSettings(true, true, true)
            );
    }
}
