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

        public override bool Equals(object obj)
        {
            return Id.Equals(((TileIdentifier)obj)?.Id, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public static bool operator ==(TileIdentifier a, TileIdentifier b) => a?.Equals(b) ?? false;
        public static bool operator !=(TileIdentifier a, TileIdentifier b) => !a?.Equals(b) ?? true;
    }
}
