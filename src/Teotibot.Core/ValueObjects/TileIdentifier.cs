using System;
using Teotibot.Core.Enums;
using Teotibot.Core.Extensions;

namespace Teotibot.Core.ValueObjects
{
    public record TileIdentifier
    {
        public TileIdentifier(string title, Set expansion, TileType tileType)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentNullException();
            }

            var prefix = expansion.GetTileSetName();
            Id = $"{prefix}-{title}-{tileType.GetTileTypeName()}";
        }

        public string Id { get; }
    }
}
