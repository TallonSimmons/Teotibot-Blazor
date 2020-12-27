using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Teotibot.Core.Entities;
using Teotibot.Core.Repositories;

namespace Teotibot.Application.Commands
{
    public class SaveGameCommand : IRequest
    {
        public Game Game { get; }

        public SaveGameCommand(Game game)
        {
            Game = game;
        }
    }

    public class SaveGameCommandHandler : IRequestHandler<SaveGameCommand>
    {
        private readonly IRepository repository;

        public SaveGameCommandHandler(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(SaveGameCommand request, CancellationToken cancellationToken)
        {
            var result = repository.CreateOrUpdate(request.Game);

            return Unit.Value;
        }
    }
}
