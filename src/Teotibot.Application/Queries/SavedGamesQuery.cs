using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Teotibot.Core.Entities;
using Teotibot.Core.Repositories;

namespace Teotibot.Application.Queries
{
    public class SavedGamesQuery : IRequest<IReadOnlyCollection<Game>>
    {
    }

    public class SavedGamesQueryHandler : IRequestHandler<SavedGamesQuery, IReadOnlyCollection<Game>>
    {
        private readonly IReadRepository repository;

        public SavedGamesQueryHandler(IReadRepository repository)
        {
            this.repository = repository;
        }
        public async Task<IReadOnlyCollection<Game>> Handle(SavedGamesQuery request, CancellationToken cancellationToken)
        {
            var gamesStream = repository.GetAllAsyncStream<Game>();
            var games = new List<Game>();

            await foreach (var game in gamesStream)
            {
                games.Add(game);
            }

            return games;
        }
    }
}
