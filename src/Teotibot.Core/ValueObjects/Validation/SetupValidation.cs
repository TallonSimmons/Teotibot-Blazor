using System;
using System.Linq;
using Teotibot.Core.Enums;
using Teotibot.Core.ValueObjects.Exceptions;
using Teotibot.Core.ValueObjects.Settings;

namespace Teotibot.Core.ValueObjects.Validation
{
    public static class SetupValidation
    {
        public static void Validate(this Setup setup, GameSettings settings)
        {
            if(settings is null ||
                settings.LatePreClassicPeriodSettings is null ||
                settings.ShadowsOfXitleSettings is null ||
                settings.PromoSettings is null)
            {
                throw new ArgumentNullException();
            }

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

            valid = setup.TechnologyTiles is not null && setup.RoyalTiles.Count == 3 &&
                setup.StartingTiles.Count == 4 &&
                setup.TechnologyTiles.Count == 6;

            if (!valid)
            {
                throw new InvalidSetupException();
            }
        }
    }
}
