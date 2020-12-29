using System;
using Teotibot.Core.Enums;

namespace Teotibot.Core.ValueObjects.Settings
{
    public record LatePreClassicPeriodSettings : ISettings
    {
        public LatePreClassicPeriodSettings(bool includePriestTiles, bool includeSeasonTiles)
        {
            IncludePriestTiles = includePriestTiles;
            IncludeSeasonTiles = includeSeasonTiles;
        }

        public bool IncludePriestTiles { get; }

        public bool IncludeSeasonTiles { get; }

        public Set Set => Set.LatePreClassicPeriod;
    }
}
