using System;
using Teotibot.Core.Entities.PyramidTiles;
using Teotibot.Core.ValueObjects;

namespace Teotibot.Core.Entities
{
    public class Game : Entity<Guid>
    {
        public Game(Guid id, Pyramid pyramid, PyramidTile setAsideTile, DirectionTile topDirectionTile, DirectionTile bottomDirectionTile, PyramidTile activeTile = null)
        {
            Id = id;
            Pyramid = pyramid ?? throw new ArgumentNullException(nameof(pyramid));
            SetAsideTile = setAsideTile ?? throw new ArgumentNullException(nameof(SetAsideTile));
            TopDirectionTile = topDirectionTile ?? throw new ArgumentNullException(nameof(topDirectionTile));
            BottomDirectionTile = bottomDirectionTile ?? throw new ArgumentNullException(nameof(bottomDirectionTile));
            ActiveTile = activeTile;
        }

        public Guid Id { get; }
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
