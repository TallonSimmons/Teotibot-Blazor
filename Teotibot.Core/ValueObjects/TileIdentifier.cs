using System;
using Teotibot.Core.Enums;
using Teotibot.Core.Extensions;

namespace Teotibot.Core.ValueObjects
{
    public class TileIdentifier
    {
        public TileIdentifier(string title, TileSet expansion)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentNullException();
            }

            var prefix = expansion.GetTileSetName();
            Id = $"{prefix}:{title}";
        }

        public string Id { get; }
    }
}
