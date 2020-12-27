using System;

namespace Teotibot.Core.ValueObjects
{
    public class TileRoll
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

        public override bool Equals(object obj)
        {
            return ((TileRoll)obj)?.Result == Result;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Result);
        }

        public static bool operator ==(TileRoll a, TileRoll b) => a?.Equals(b) ?? false;
        public static bool operator !=(TileRoll a, TileRoll b) => !a?.Equals(b) ?? true;
    }
}
