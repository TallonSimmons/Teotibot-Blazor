using System;
using Teotibot.Core.Entities;
using Teotibot.Core.Entities.Tiles;
using Teotibot.Core.Entities.Tiles.PyramidTiles;
using Teotibot.Core.Enums;
using Teotibot.Core.ValueObjects;
using Xunit;

namespace Teotibot.Core.UnitTests.Entities.GameTests
{
    public class GameShouldNot : IClassFixture<GameTestFixture>
    {
        private readonly GameTestFixture fixture;

        public GameShouldNot(GameTestFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void Not_Leave_Empty_Pyramid_Positions_After_RollForTile()
        {
            var pyramid = new Pyramid(fixture.Tiles);

            var game = new Game(Guid.NewGuid(), pyramid, new PyramidTile("Test", TileSet.BaseGame, ""), new DirectionTile(), new DirectionTile());

            game.RollForTile();

            Assert.True(!game.Pyramid.HasEmptyPyramidPositions);
        }
    }
}
