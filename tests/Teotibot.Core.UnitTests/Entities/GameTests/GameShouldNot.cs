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

            var game = new Game(Guid.NewGuid(), fixture.EverythingOnGameSettings, pyramid, new PyramidTile("Test", Set.BaseGame, ""), new DirectionTile(), new DirectionTile(), null);

            game.RollForTile();

            Assert.True(!game.Pyramid.HasEmptyPyramidPositions);
        }
    }
}
