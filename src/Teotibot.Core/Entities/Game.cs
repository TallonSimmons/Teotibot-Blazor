﻿using System;
using Teotibot.Core.Entities.Tiles;
using Teotibot.Core.Entities.Tiles.PyramidTiles;
using Teotibot.Core.ValueObjects;
using Teotibot.Core.ValueObjects.Settings;

namespace Teotibot.Core.Entities
{
    public class Game : Entity<Guid>
    {
        public Game(Guid id, GameSettings settings, Pyramid pyramid, PyramidTile setAsideTile, DirectionTile topDirectionTile, DirectionTile bottomDirectionTile, PyramidTile? activeTile)
            : base(id)
        {
            Settings = settings;
            Pyramid = pyramid ?? throw new ArgumentNullException(nameof(pyramid));
            SetAsideTile = setAsideTile ?? throw new ArgumentNullException(nameof(SetAsideTile));
            TopDirectionTile = topDirectionTile ?? throw new ArgumentNullException(nameof(topDirectionTile));
            BottomDirectionTile = bottomDirectionTile ?? throw new ArgumentNullException(nameof(bottomDirectionTile));
            ActiveTile = activeTile;
        }

        public GameSettings Settings { get; }
        public Pyramid Pyramid { get; }
        public PyramidTile ActiveTile { get; private set; }
        public PyramidTile SetAsideTile { get; private set; }
        public DirectionTile TopDirectionTile { get; private set; }
        public DirectionTile BottomDirectionTile { get; private set; }

        public void RollForTile()
        {
            ActiveTile = Pyramid.ActivateTile(new TileRoll());
            Pyramid.FillNextEmptyPyramidPosition(TopDirectionTile, SetAsideTile);
            UpdateDirectionTiles();

            while (Pyramid.HasEmptyPyramidPositions)
            {
                Pyramid.FillNextEmptyPyramidPosition(TopDirectionTile, SetAsideTile);
            }

            SetAsideTile = ActiveTile;

            #region Local Functions
            void UpdateDirectionTiles()
            {
                var tempTopTile = TopDirectionTile;
                TopDirectionTile = BottomDirectionTile;
                BottomDirectionTile = tempTopTile;
                BottomDirectionTile.FlipDirection();
            }
            #endregion

        }
    }
}
