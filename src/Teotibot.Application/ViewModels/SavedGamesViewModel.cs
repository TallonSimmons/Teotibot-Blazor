using System.Collections.Generic;
using System.Linq;
using Teotibot.Core.Entities;

namespace Teotibot.Application.ViewModels
{
    public class SavedGamesViewModel
    {
        public IReadOnlyCollection<Game> SavedGames { get; }

        public SavedGamesViewModel(IEnumerable<Game> savedGames)
        {
            SavedGames = savedGames.ToList().AsReadOnly();
        }
    }
}
