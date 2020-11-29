using System;
using Teotibot.Core.ValueObjects;

namespace Teotibot.Core.Entities
{
    public class Game
    {
        public Guid Id { get; }
        public Pyramid Pyramid { get; }
        public PyramidTile ActiveTile { get; private set; }
        public PyramidTile SetAsideTile { get; private set; }
        public Die DieOne { get; }
        public Die DieTwo { get; }
        public DirectionTile TopDirectionTile { get; private set; }
        public DirectionTile BottomDirectionTile { get; private set; }

        public void ShiftDirectionTiles()
        {
            var tempTopTile = TopDirectionTile;
            BottomDirectionTile = TopDirectionTile;
            TopDirectionTile = tempTopTile;
            TopDirectionTile.FlipDirection();
        }

        public void RollForTile()
        {
            DieOne.Roll();
            DieTwo.Roll();

            ActiveTile = Pyramid.ActivateTile(DieOne, DieTwo);
        }
    }
}
