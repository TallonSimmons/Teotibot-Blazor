using System;
using Teotibot.Core.Enums;

namespace Teotibot.Core.Entities.Tiles
{
    public class DirectionTile
    {
        public DirectionTile()
        {
            SetRandomDirection();

            void SetRandomDirection()
            {
                var random = new Random();
                var values = Enum.GetValues(typeof(ReplacementDirection));
                Direction = (ReplacementDirection)values.GetValue(random.Next(values.Length));
            }
        }

        public ReplacementDirection Direction { get; private set; }

        public void FlipDirection()
        {
            switch (Direction)
            {
                case ReplacementDirection.Left:
                    Direction = ReplacementDirection.Right;
                    break;
                case ReplacementDirection.Right:
                    Direction = ReplacementDirection.Left;
                    break;
                default:
                    break;
            }
        }
    }
}
