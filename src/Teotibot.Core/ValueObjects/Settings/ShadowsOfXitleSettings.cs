using System;
using Teotibot.Core.Enums;

namespace Teotibot.Core.ValueObjects.Settings
{
    public class ShadowsOfXitleSettings : IStartingTileSettings, ITechnologyTileSettings
    {
        public ShadowsOfXitleSettings(bool includeTechnologyTiles, bool includeStartingTiles)
        {
            IncludeTechnologyTiles = includeTechnologyTiles;
            IncludeStartingTiles = includeStartingTiles;
        }

        public bool IncludeTechnologyTiles { get; }
        public bool IncludeStartingTiles { get; }
        public Set Set => Set.ShadowsOfXitle;

        public override bool Equals(object obj)
        {
            return !(obj is null) && obj is ShadowsOfXitleSettings settings &&
                   IncludeTechnologyTiles == settings.IncludeTechnologyTiles &&
                   IncludeStartingTiles == settings.IncludeStartingTiles &&
                   Set == settings.Set;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(IncludeTechnologyTiles, IncludeStartingTiles, Set);
        }

        public static bool operator ==(ShadowsOfXitleSettings a, ShadowsOfXitleSettings b) => a?.Equals(b) ?? false;
        public static bool operator !=(ShadowsOfXitleSettings a, ShadowsOfXitleSettings b) => !a?.Equals(b) ?? true;
    }
}
