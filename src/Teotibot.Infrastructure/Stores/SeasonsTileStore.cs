using System.Collections.Generic;
using Teotibot.Core.Entities;
using Teotibot.Core.Store;

namespace Teotibot.Infrastructure.Stores
{
    internal class SeasonsTileStore : IReadStore<SeasonTile>
    {
        public IEnumerable<SeasonTile> GetAll()
        {
            var seasonTiles = new List<SeasonTile>();

            for (int i = 1; i < 9; i++)
            {
                seasonTiles.Add(new SeasonTile(i.ToString()));
            }

            return seasonTiles;
        }
    }
}
