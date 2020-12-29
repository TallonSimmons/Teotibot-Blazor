using System.Collections.Generic;
using Teotibot.Core.Entities.Tiles;
using Teotibot.Core.Enums;
using Teotibot.Core.ValueObjects;

namespace Teotibot.Core.UnitTests.Shared.Fixtures
{
    public class SetupFixture
    {
        private static readonly RoyalTile royalTile1 = new RoyalTile("1", Set.BaseGame, RoyalTileCategory.A);
        private static readonly RoyalTile royalTile2 = new RoyalTile("2", Set.BaseGame, RoyalTileCategory.B);
        private static readonly RoyalTile royalTile3 = new RoyalTile("3", Set.BaseGame, RoyalTileCategory.C);

        public readonly GameTestFixture GameTestFixture = new GameTestFixture();

        public IReadOnlyCollection<RoyalTile> ValidBaseGameRoyalTiles =
            new List<RoyalTile>
            {
                royalTile1,
                royalTile2,
                royalTile3
            };

        public IReadOnlyCollection<StartingTile> ValidBaseGameStartingTiles = new List<StartingTile>
            {
                new StartingTile("1", Set.BaseGame),
                new StartingTile("2", Set.BaseGame),
                new StartingTile("3", Set.BaseGame),
                new StartingTile("4", Set.BaseGame),
            };

        public IReadOnlyCollection<PriestTile> ValidPriestTiles = new List<PriestTile>
            {
                new PriestTile("1", PriestTileType.Player),
                new PriestTile("1", PriestTileType.Teotibot),
            };

        public IReadOnlyCollection<TechnologyTile> ValidBaseGameTechnologyTiles = new List<TechnologyTile>
            {
                new TechnologyTile("1", Set.BaseGame),
                new TechnologyTile("2", Set.BaseGame),
                new TechnologyTile("3", Set.BaseGame),
                new TechnologyTile("4", Set.BaseGame),
                new TechnologyTile("5", Set.BaseGame),
                new TechnologyTile("6", Set.BaseGame),
            };

        public IReadOnlyCollection<SeasonTile> ValidSeasonTiles = new List<SeasonTile>
            {
                new SeasonTile("1"),
                new SeasonTile("2"),
                new SeasonTile("3"),
        };
    }
}
