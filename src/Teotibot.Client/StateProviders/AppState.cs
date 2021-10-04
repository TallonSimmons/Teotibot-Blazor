using Teotibot.Core.Entities;

namespace Teotibot.Client.Store
{
    public class AppState : StateBase
    {
        public AppState(Game game)
        {
            Game = game;
        }

        public Game Game { get; }
    }
}
