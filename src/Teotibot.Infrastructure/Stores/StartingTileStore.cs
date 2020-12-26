using System.Collections.Generic;
using Teotibot.Core.Entities;
using Teotibot.Core.Enums;
using Teotibot.Core.Store;

namespace Teotibot.Infrastructure.Stores
{
    internal class StartingTileStore : IReadStore<StartingTile>
    {
        public IEnumerable<StartingTile> GetAll()
        {
            var startingTiles = new List<StartingTile>();

            AddTiles(18, TileSet.BaseGame);
            AddTiles(2, TileSet.Promo);
            AddTiles(10, TileSet.ShadowsOfXitle);

            return startingTiles;

            #region Local functions
            void AddTiles(int numberOfTilesToAdd, TileSet tileSet)
            {
                for (int i = 1; i < numberOfTilesToAdd + 1; i++)
                {
                    startingTiles.Add(new StartingTile(i.ToString(), tileSet));
                }
            }
            #endregion
        }
    }
}
