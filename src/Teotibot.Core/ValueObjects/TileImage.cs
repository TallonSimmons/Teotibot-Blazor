using System;
using Teotibot.Core.Enums;
using Teotibot.Core.Extensions;

namespace Teotibot.Core.ValueObjects
{
    public record TileImage
    {
        public TileImage(string title, Set tileSet, TileType tileType)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentNullException();
            }

            var prefix = tileSet.GetTileSetName();
            Path = $"{prefix}-{tileType}-{title}.png";
        }

        public string Path { get; }
    }
}
