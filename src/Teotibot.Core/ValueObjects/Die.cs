using System;

namespace Teotibot.Core.ValueObjects
{
    public class Die
    {
        private static readonly Random Random = new Random();
        public int Face { get; private set; }

        public void Roll()
        {
            Face = Random.Next(1, 6);
        }

        public override bool Equals(object obj) => ((Die)obj)?.Face == Face;
        public static bool operator ==(Die a, Die b) => a?.Equals(b) ?? false;
        public static bool operator !=(Die a, Die b) => !a?.Equals(b) ?? true;
    }
}
