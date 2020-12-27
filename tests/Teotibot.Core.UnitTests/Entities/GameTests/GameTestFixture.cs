using System.Collections.Generic;
using Teotibot.Core.Entities.Tiles.PyramidTiles;
using Teotibot.Core.Enums;

namespace Teotibot.Core.UnitTests.Entities.GameTests
{
    public class GameTestFixture
    {
        public readonly IEnumerable<PyramidTile> Tiles = new List<PyramidTile>
        {
            new PyramidTile("Test", TileSet.BaseGame, "instructions"),
            new PyramidTile("Test", TileSet.BaseGame, "instructions"),
            new PyramidTile("Test", TileSet.BaseGame, "instructions"),
            new PyramidTile("Test", TileSet.BaseGame, "instructions"),
            new PyramidTile("Test", TileSet.BaseGame, "instructions"),
            new PyramidTile("Test", TileSet.BaseGame, "instructions"),
        };

    }
}
