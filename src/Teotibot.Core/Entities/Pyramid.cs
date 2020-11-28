using System;
using System.Collections.Generic;
using System.Linq;
using Teotibot.Core.Extensions;
using Teotibot.Core.ValueObjects;

namespace Teotibot.Core.Entities
{
    public class Pyramid
    {
        private DirectionTile topTile = new DirectionTile();
        private DirectionTile bottomTile = new DirectionTile();

        public Pyramid(IEnumerable<PyramidTile> tiles)
        {
            if (tiles is null)
            {
                throw new ArgumentNullException(nameof(tiles));
            }

            if (tiles.Count() != 7)
            {
                throw new ArgumentOutOfRangeException();
            }

            var shuffledTiles = tiles.Shuffle().ToList();

            for (int i = 0; i < 7; i++)
            {
                var currentTile = shuffledTiles[i];
                currentTile.PyramidPosition = new PyramidPosition(i + 1);
                PyramidPositions.Add(currentTile.PyramidPosition, currentTile);
            }

            SetAsideTile = shuffledTiles[8];
        }

        public PyramidTile SetAsideTile { get; }
        public readonly Dictionary<PyramidPosition, PyramidTile> PyramidPositions = new Dictionary<PyramidPosition, PyramidTile>();

        public PyramidTile ActivateTile(Die dieOne, Die dieTwo)
        {
            var result = dieOne.Face + dieTwo.Face;

            var targetedPyramidPosition = PyramidPositions.FirstOrDefault(p => p.Value.Trigger.TriggerNumbers.Contains(result));

            var triggeredPyramidPosition = targetedPyramidPosition.Key;
            var activatedTile = targetedPyramidPosition.Value;
            PyramidPositions[triggeredPyramidPosition] = null;

            return activatedTile;

            void UpdatePositions()
            {
                var positionToReplace = PyramidPositions.FirstOrDefault(x => x.Value == null);

                var replacementPositionNumber = positionToReplace.Key.GetReplacementPosition(topTile.Direction);
                var replaceFromPosition = PyramidPositions.FirstOrDefault(x => x.Key.Position == replacementPositionNumber);

                if(replacementPositionNumber == 0)
                {
                    PyramidPositions[positionToReplace.Key] = SetAsideTile;

                    return;
                }

                PyramidPositions[positionToReplace.Key] = replaceFromPosition.Value;

                PyramidPositions[replaceFromPosition.Key] = null;

                if(PyramidPositions.Any(x => x.Value == null))
                {
                    UpdatePositions();
                }
            }
        }
    }
}
