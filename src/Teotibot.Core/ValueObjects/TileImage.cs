using System;
using Teotibot.Core.Enums;
using Teotibot.Core.Extensions;

namespace Teotibot.Core.ValueObjects
{
    public class TileImage
    {
        public TileImage(string title, TileSet tileSet)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentNullException();
            }

            var prefix = tileSet.GetTileSetName();
            Path = $"{prefix}-{title}.png";
        }

        public string Path { get; }

        public override bool Equals(object obj)
        {
            return Path.Equals(((TileImage)obj)?.Path, StringComparison.OrdinalIgnoreCase);
        }
        public static bool operator ==(TileImage a, TileImage b) => a?.Equals(b) ?? false;
        public static bool operator !=(TileImage a, TileImage b) => !a?.Equals(b) ?? true;
    }
}
