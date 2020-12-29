using System;
using Teotibot.Core.Enums;

namespace Teotibot.Core.ValueObjects.Settings
{
    public record PromoSettings : ISettings
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
    }
}
