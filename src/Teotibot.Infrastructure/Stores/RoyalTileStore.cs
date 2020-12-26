using System;
using System.Collections.Generic;
using Teotibot.Core.Entities;
using Teotibot.Core.Enums;
using Teotibot.Core.Store;

namespace Teotibot.Infrastructure.Stores
{
    internal class RoyalTileStore : IReadStore<RoyalTile>
    {
        public IEnumerable<RoyalTile> GetAll()
        {
            var royalTiles = new List<RoyalTile>();

            AddBaseGameTiles();
            AddPromoTiles();

            return royalTiles;

            void AddBaseGameTiles()
            {
                foreach (var category in Enum.GetValues(typeof(RoyalTileCategory)))
                {
                    for (int i = 0; i < 3; i++)
                    {
                        royalTiles.Add(new RoyalTile(i.ToString(), TileSet.BaseGame, (RoyalTileCategory)category));
                    }
                }
            }

            void AddPromoTiles()
            {
                royalTiles.Add(new RoyalTile(1.ToString(), TileSet.Promo, RoyalTileCategory.A));
                royalTiles.Add(new RoyalTile(2.ToString(), TileSet.Promo, RoyalTileCategory.C));
            }
        }
    }
}
