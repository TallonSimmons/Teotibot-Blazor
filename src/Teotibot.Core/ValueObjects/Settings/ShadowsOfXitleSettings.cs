using System;
using Teotibot.Core.Enums;

namespace Teotibot.Core.ValueObjects.Settings
{
    public record ShadowsOfXitleSettings : ISettings
    {
        public ShadowsOfXitleSettings(bool includeTechnologyTiles, bool includeStartingTiles)
        {
            IncludeTechnologyTiles = includeTechnologyTiles;
            IncludeStartingTiles = includeStartingTiles;
        }

        public bool IncludeTechnologyTiles { get; }
        public bool IncludeStartingTiles { get; }
        public Set Set => Set.ShadowsOfXitle;
    }
}
