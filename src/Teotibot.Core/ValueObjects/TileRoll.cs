using System;

namespace Teotibot.Core.ValueObjects
{
    public record TileRoll
    {
        public TileRoll()
        {
            var dieOne = new Die();
            dieOne.Roll();
            var dieTwo = new Die();
            dieTwo.Roll();

            Result = dieOne.Face + dieTwo.Face;
        }

        public int Result { get; }
    }
}
