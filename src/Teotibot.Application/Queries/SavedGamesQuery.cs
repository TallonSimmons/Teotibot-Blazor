using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Teotibot.Application.ViewModels;
using Teotibot.Core.Entities;
using Teotibot.Core.Repositories;

namespace Teotibot.Application.Queries
{
    public class SavedGamesQuery : IRequest<SavedGamesViewModel>
    {
    }

    public class SavedGamesQueryHandler : IRequestHandler<IRequest<SavedGamesViewModel>, SavedGamesViewModel>
    {
        private readonly IReadRepository repository;

        public SavedGamesQueryHandler(IReadRepository repository)
        {
            this.repository = repository;
        }

        public async Task<SavedGamesViewModel> Handle(IRequest<SavedGamesViewModel> request, CancellationToken cancellationToken)
        {
            var gamesStream = repository.GetAllAsyncStream<Game>();
            var games = new List<Game>();

            await foreach (var game in gamesStream)
            {
                games.Add(game);
            }

            return new SavedGamesViewModel(games);
        }
    }
}
