using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using Teotibot.Core.Entities;
using Teotibot.Core.Entities.Tiles;
using Teotibot.Core.Entities.Tiles.PyramidTiles;
using Teotibot.Core.Store;
using Teotibot.Core.ValueObjects;
using Teotibot.Core.ValueObjects.Settings;

namespace Teotibot.Application.Queries
{
    public class DefaultGameQuery : IRequest<Game>
    {
    }

    internal class DefaultGameQueryHandler : IRequestHandler<DefaultGameQuery, Game>
    {
        private readonly IReadStore<RoyalTile> royalTileStore;
        private readonly IReadStore<TechnologyTile> techTileStore;
        private readonly IReadStore<StartingTile> startingTileStore;
        private readonly IReadStore<SeasonTile> seasonTileStore;
        private readonly IReadStore<PyramidTile> pyramidTileStore;

        public DefaultGameQueryHandler(
            IReadStore<RoyalTile> royalTileStore,
            IReadStore<TechnologyTile> techTileStore,
            IReadStore<StartingTile> startingTileStore,
            IReadStore<SeasonTile> seasonTileStore,
            IReadStore<PyramidTile> pyramidTileStore)
        {
            this.royalTileStore = royalTileStore;
            this.techTileStore = techTileStore;
            this.startingTileStore = startingTileStore;
            this.seasonTileStore = seasonTileStore;
            this.pyramidTileStore = pyramidTileStore;
        }
        public Task<Game> Handle(DefaultGameQuery request, CancellationToken cancellationToken)
        {
            var gameSettings = new GameSettings(
                    new LatePreClassicPeriodSettings(false, false),
                    new ShadowsOfXitleSettings(false, false),
                    new PromoSettings(false, false, false));

            var pyramidCreationResult = Pyramid.CreateFromPyramidTileCollection(pyramidTileStore.GetAll());

            return Task.FromResult(new Game(
                Guid.NewGuid(), 
                gameSettings, 
                pyramidCreationResult.Pyramid, 
                pyramidCreationResult.SetAsideTile, 
                new DirectionTile(), 
                new DirectionTile(), 
                null));

            
        }
    }
}
