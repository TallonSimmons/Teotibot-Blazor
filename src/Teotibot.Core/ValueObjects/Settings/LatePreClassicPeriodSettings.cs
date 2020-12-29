using System;
using Teotibot.Core.Enums;

namespace Teotibot.Core.ValueObjects.Settings
{
    public class LatePreClassicPeriodSettings : ISeasonTileSettings, IPriestTileSettings
    {
        public LatePreClassicPeriodSettings(bool includePriestTiles, bool includeSeasonTiles)
        {
            IncludePriestTiles = includePriestTiles;
            IncludeSeasonTiles = includeSeasonTiles;
        }

        public bool IncludePriestTiles { get; }

        public bool IncludeSeasonTiles { get; }

        public Set Set => Set.LatePreClassicPeriod;

        public override bool Equals(object obj)
        {
            return !(obj is null) &&
                obj is LatePreClassicPeriodSettings settings &&
                IncludePriestTiles == settings.IncludePriestTiles &&
                IncludeSeasonTiles == settings.IncludeSeasonTiles &&
                Set == settings.Set;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(IncludePriestTiles, IncludeSeasonTiles, Set);
        }

        public static bool operator ==(LatePreClassicPeriodSettings a, LatePreClassicPeriodSettings b) => a?.Equals(b) ?? false;
        public static bool operator !=(LatePreClassicPeriodSettings a, LatePreClassicPeriodSettings b) => !a?.Equals(b) ?? true;
    }
}
