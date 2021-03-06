﻿using System.Collections.Generic;
using Teotibot.Core.Entities.Tiles;
using Teotibot.Core.Enums;
using Teotibot.Core.Store;

namespace Teotibot.Infrastructure.Stores
{
    internal class StartingTileStore : IReadStore<StartingTile>
    {
        public IEnumerable<StartingTile> GetAll()
        {
            var startingTiles = new List<StartingTile>();

            AddTiles(18, Set.BaseGame);
            AddTiles(2, Set.Promo);
            AddTiles(10, Set.ShadowsOfXitle);

            return startingTiles;

            #region Local functions
            void AddTiles(int numberOfTilesToAdd, Set tileSet)
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
