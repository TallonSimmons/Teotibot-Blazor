using System;
using System.Collections.Generic;
using System.Linq;
using Teotibot.Core.Entities.Tiles;
using Teotibot.Core.Enums;
using Teotibot.Core.Extensions;
using Teotibot.Core.ValueObjects.Settings;
using Teotibot.Core.ValueObjects.Validation;

namespace Teotibot.Core.ValueObjects
{
    public record Setup
    {
        public Setup(GameSettings settings, IReadOnlyCollection<RoyalTile> royalTiles, IReadOnlyCollection<StartingTile> startingTiles, IReadOnlyCollection<PriestTile> priestTiles, IReadOnlyCollection<TechnologyTile> technologyTiles, IReadOnlyCollection<SeasonTile> seasonTiles)
        {
            RoyalTiles = GetRoyalTilesForSettings(settings, royalTiles);
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

        static IReadOnlyCollection<RoyalTile> GetRoyalTilesForSettings(GameSettings settings, IReadOnlyCollection<RoyalTile> tiles)
        {
            var includedTiles = new List<RoyalTile>();
            if (settings.PromoSettings.IncludeRoyalTiles)
            {
                includedTiles.AddRange(tiles.Where(x => x.TileSet == Set.Promo));
            }

            includedTiles.AddRange(tiles.Where(x => x.TileSet == Set.BaseGame));

            includedTiles.Shuffle();

            return new List<RoyalTile>
            {
                tiles.FirstOrDefault(x => x.Category == RoyalTileCategory.A),
                tiles.FirstOrDefault(x => x.Category == RoyalTileCategory.B),
                tiles.FirstOrDefault(x => x.Category == RoyalTileCategory.C),
            };
        }
    }
}
