using System;
using System.Collections.Generic;
using System.Text;
using Teotibot.Core.Entities;
using Teotibot.Core.Enums;
using Teotibot.Core.Store;

namespace Teotibot.Infrastructure.Stores
{
    internal class TechnologyTileStore : IReadStore<TechnologyTile>
    {
        public IEnumerable<TechnologyTile> GetAll()
        {
            var technologyTiles = new List<TechnologyTile>();
            AddTiles(9, TileSet.BaseGame);
            AddTiles(1, TileSet.Promo);
            AddTiles(10, TileSet.ShadowsOfXitle);

            return technologyTiles;

            #region Local Functions
            void AddTiles(int numberOfTilesToAdd, TileSet tileSet)
            {
                for (var i = 1; i < numberOfTilesToAdd + 1; i++)
                {
                    technologyTiles.Add(new TechnologyTile(i.ToString(), tileSet));
                }
            }
            #endregion
        }
    }
}
