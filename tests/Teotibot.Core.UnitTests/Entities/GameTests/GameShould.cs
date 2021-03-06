﻿using System;
using Teotibot.Core.Entities;
using Teotibot.Core.Entities.Tiles;
using Teotibot.Core.Entities.Tiles.PyramidTiles;
using Teotibot.Core.Enums;
using Teotibot.Core.UnitTests.Shared.Fixtures;
using Teotibot.Core.ValueObjects;
using Xunit;

namespace Teotibot.Core.UnitTests.Entities.GameTests
{
    public class GameShould : IClassFixture<GameTestFixture>
    {
        private readonly GameTestFixture fixture;

        public GameShould(GameTestFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void Flip_And_Move_Direction_Tiles_Properly()
        {
            var pyramid = new Pyramid(fixture.Tiles);

            var game = new Game(Guid.NewGuid(), fixture.EverythingOnGameSettings, pyramid, new PyramidTile("Test", Set.BaseGame, ""), new DirectionTile(), new DirectionTile(), null);
            var expectedBottomDirection = game.TopDirectionTile.Direction == ReplacementDirection.Left ? ReplacementDirection.Right : ReplacementDirection.Left;
            var expectedTopDirection = game.BottomDirectionTile.Direction;

            game.RollForTile();

            Assert.True(expectedBottomDirection == game.BottomDirectionTile.Direction && expectedTopDirection == game.TopDirectionTile.Direction);
        }
    }
}
