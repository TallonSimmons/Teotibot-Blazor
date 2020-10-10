using System;

namespace Teotibot.Core.ValueObjects
{
    public class PyramidPosition
    {
        public PyramidPosition(int position)
        {
            if (position < 1 || position > 6)
            {
                throw new ArgumentOutOfRangeException();
            }

            Position = position;
        }

        public int Position { get; }

    }
}
