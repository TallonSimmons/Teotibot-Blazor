using System.Collections.Generic;
using Teotibot.Core.Entities.Tiles.PyramidTiles;
using Teotibot.Core.Store;

namespace Teotibot.Infrastructure.Stores
{
    internal sealed class PyramidTileStore : IReadStore<PyramidTile>
    {
        public IEnumerable<PyramidTile> GetAll() =>
            new List<PyramidTile>
            {
                new AlchemyPyramidTile(),
                new ConstructionPyramidTile(),
                new DecorationsPyramidTile(),
                new MaskCollectionPyramidTile(),
                new MasteryPyramidTile(),
                new NoblesPyramidTile(),
                new WorshipPyramidTile()
            };
    }
}
