using System.Collections.Generic;
using Teotibot.Core.Entities.PyramidTiles;
using Teotibot.Core.Store;

namespace Teotibot.Infrastructure.Stores
{
    public class PyramidTileStore : IReadStore<PyramidTile>
    {
        public IEnumerable<PyramidTile> GetAll() =>
            new List<PyramidTile>
            {
                new ConstructionPyramidTile(),
            };
    }
}
