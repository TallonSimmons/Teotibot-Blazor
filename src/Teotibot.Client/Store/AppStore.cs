using Teotibot.Core.Entities;

namespace Teotibot.Client.Store
{
    public class AppStore : StoreBase
    {
        public AppStore(Game game)
        {
            Game = game;
        }

        public Game Game { get; }
    }
}
