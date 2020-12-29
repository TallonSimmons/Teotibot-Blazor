using System;
using System.Collections.Generic;
using Teotibot.Core.Entities.Tiles;
using Teotibot.Core.ValueObjects.Settings;
using Teotibot.Core.ValueObjects.Validation;

namespace Teotibot.Core.ValueObjects
{
    public class Setup
    {
        public Setup(GameSettings settings, IReadOnlyCollection<RoyalTile> royalTiles, IReadOnlyCollection<StartingTile> startingTiles, IReadOnlyCollection<PriestTile> priestTiles, IReadOnlyCollection<TechnologyTile> technologyTiles, IReadOnlyCollection<SeasonTile> seasonTiles)
        {
            RoyalTiles = royalTiles;
            StartingTiles = startingTiles;
            PriestTiles = priestTiles;
            TechnologyTiles = technologyTiles;
            SeasonTiles = seasonTiles;
            this.Validate(settings);
        }

        public IReadOnlyCollection<RoyalTile> RoyalTiles { get; }
        public IReadOnlyCollection<StartingTile> StartingTiles { get; }
        public IReadOnlyCollection<PriestTile> PriestTiles { get; }
        public IReadOnlyCollection<TechnologyTile> TechnologyTiles { get; }
        public IReadOnlyCollection<SeasonTile> SeasonTiles { get; }
    }
}
