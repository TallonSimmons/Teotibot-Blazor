using System.Linq;
using Teotibot.Core.Enums;
using Teotibot.Core.ValueObjects.Settings;

namespace Teotibot.Core.ValueObjects.Validation
{
    public static class SetupValidation
    {
        public static void Validate(this Setup setup, GameSettings settings)
        {
            var valid = true;
            if (settings.LatePreClassicPeriodSettings.IncludePriestTiles)
            {
                valid = setup.PriestTiles.Count(x => x.PriestTileType == PriestTileType.Player) == 1
                    && setup.PriestTiles.Count(x => x.PriestTileType == PriestTileType.Teotibot) == 1;
            }
            if (settings.LatePreClassicPeriodSettings.IncludeSeasonTiles)
            {
                valid = setup.SeasonTiles.Count() == 3;
            }
        }
    }
}
