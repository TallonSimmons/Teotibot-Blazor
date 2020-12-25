using System;
using System.Collections.Generic;
using Teotibot.Core.Entities;
using Teotibot.Core.Enums;
using Xunit;

namespace Teotibot.Core.UnitTests.Entities
{
    public class GameShould
    {
        private readonly IEnumerable<PyramidTile> tiles = new List<PyramidTile>
        {
            new PyramidTile("Test", TileSet.BaseGame, "instructions"),
            new PyramidTile("Test", TileSet.BaseGame, "instructions"),
            new PyramidTile("Test", TileSet.BaseGame, "instructions"),
            new PyramidTile("Test", TileSet.BaseGame, "instructions"),
            new PyramidTile("Test", TileSet.BaseGame, "instructions"),
            new PyramidTile("Test", TileSet.BaseGame, "instructions"),
        };

        [Fact]
        public void Flip_And_Move_Direction_Tiles_Properly()
        {
            var pyramid = new Pyramid(tiles);

            var game = new Game(Guid.NewGuid(), pyramid, new PyramidTile("Test", TileSet.BaseGame, ""), new DirectionTile(), new DirectionTile());
            var expectedBottomDirection = game.TopDirectionTile.Direction == ReplacementDirection.Left ? ReplacementDirection.Right : ReplacementDirection.Left;
            var expectedTopDirection = game.BottomDirectionTile.Direction;

            game.RollForTile();

            Assert.True(expectedBottomDirection == game.BottomDirectionTile.Direction && expectedTopDirection == game.TopDirectionTile.Direction);
        }

        [Fact]
        public void Not_Leave_Empty_Pyramid_Positions_After_RollForTile()
        {

            var pyramid = new Pyramid(tiles);

            var game = new Game(Guid.NewGuid(), pyramid, new PyramidTile("Test", TileSet.BaseGame, ""), new DirectionTile(), new DirectionTile());

            game.RollForTile();

            Assert.True(!game.Pyramid.HasEmptyPyramidPositions);
        }
    }
}
