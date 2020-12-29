using System;
using Teotibot.Core.Enums;

namespace Teotibot.Core.ValueObjects.Settings
{
    public class PromoSettings : ISettings
    {
        public PromoSettings(bool includeTechnologyTiles, bool includeRoyalTiles, bool includeStartingTiles)
        {
            IncludeTechnologyTiles = includeTechnologyTiles;
            IncludeRoyalTiles = includeRoyalTiles;
            IncludeStartingTiles = includeStartingTiles;
        }

        public bool IncludeTechnologyTiles { get; }
        public bool IncludeRoyalTiles { get; }
        public bool IncludeStartingTiles { get; }
        public Set Set => Set.Promo;

        public override bool Equals(object obj)
        {
            return !(obj is null) &&
                obj is PromoSettings settings &&
                IncludeTechnologyTiles == settings.IncludeTechnologyTiles &&
                IncludeRoyalTiles == settings.IncludeRoyalTiles &&
                IncludeStartingTiles == settings.IncludeStartingTiles &&
                Set == settings.Set;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(IncludeTechnologyTiles, IncludeRoyalTiles, IncludeStartingTiles, Set);
        }

        public static bool operator ==(PromoSettings a, PromoSettings b) => a?.Equals(b) ?? false;
        public static bool operator !=(PromoSettings a, PromoSettings b) => !a?.Equals(b) ?? true;
    }
}
