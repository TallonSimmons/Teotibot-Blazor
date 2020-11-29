using System.Collections.Generic;
using Teotibot.Core.Entities;
using Teotibot.Core.Enums;
using Teotibot.Core.ValueObjects;
using Xunit;

namespace Teotibot.Core.UnitTests.Entities
{
    public class PyramidShould
    {
        private readonly IEnumerable<PyramidTile> tiles = new List<PyramidTile>
        {
            new PyramidTile("Test", TileSet.BaseGame, "instructions"),
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
            var dieOne = new Die();
            var dieTwo = new Die();
            dieOne.Roll();
            dieTwo.Roll();

            var topDirection = pyramid.TopTile.Direction;
            var bottomDirection = pyramid.BottomTile.Direction;
            var expectedBottomDirection = topDirection == ReplacementDirection.Left ? ReplacementDirection.Right : ReplacementDirection.Left;
            var expectedTopDirection = bottomDirection;

            var tile = pyramid.ActivateTile(dieOne, dieTwo);

            Assert.True(expectedBottomDirection == pyramid.BottomTile.Direction && expectedTopDirection == pyramid.TopTile.Direction);
        }
    }
}
