using System;
using Teotibot.Core.Entities;
using Teotibot.Core.ValueObjects.Settings;

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
