using System;

namespace Teotibot.Core.ValueObjects
{
    public record Die
    {
        private static readonly Random Random = new Random();
        public int Face { get; private set; }

        public void Roll()
        {
            Face = Random.Next(1, 6);
        }
    }
}
