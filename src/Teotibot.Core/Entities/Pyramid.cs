using System;
using System.Collections.Generic;
using System.Linq;
using Teotibot.Core.Extensions;
using Teotibot.Core.ValueObjects;

namespace Teotibot.Core.Entities
{
    public class Pyramid
    {
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

            for (int i = 0; i < 6; i++)
            {
                var currentTile = shuffledTiles[i];
                currentTile.PyramidPosition = new PyramidPosition(i + 1);
                PyramidPositions.Add(currentTile.PyramidPosition, currentTile);
            }

            SetAsideTile = shuffledTiles[6];
        }

        public PyramidTile SetAsideTile { get; }
        public readonly Dictionary<PyramidPosition, PyramidTile> PyramidPositions = new Dictionary<PyramidPosition, PyramidTile>();
        public DirectionTile TopTile = new DirectionTile();
        public DirectionTile BottomTile = new DirectionTile();

        public PyramidTile ActivateTile(Die dieOne, Die dieTwo)
        {
            var result = dieOne.Face + dieTwo.Face;

            var targetedPyramidPosition = PyramidPositions
                .FirstOrDefault(p => p.Key.GetPositionTrigger()?.TriggerNumbers.Contains(result) ?? false);

            var triggeredPyramidPosition = targetedPyramidPosition.Key;
            var activatedTile = targetedPyramidPosition.Value;

            var tilesMoved = false;
            UpdatePositions(triggeredPyramidPosition);

            return activatedTile;

            #region Local functions
            void UpdatePositions(PyramidPosition triggeredPosition)
            {
                PyramidPositions[triggeredPosition] = null;
                var positionToReplace = PyramidPositions.FirstOrDefault(x => x.Value == null);

                var replacementPositionNumber = positionToReplace.Key.GetReplacementPosition(TopTile.Direction);
                var replaceFromPosition = PyramidPositions.FirstOrDefault(x => x.Key.Position == replacementPositionNumber);

                if (replacementPositionNumber == 0)
                {
                    PyramidPositions[positionToReplace.Key] = SetAsideTile;
                }
                else
                {
                    PyramidPositions[positionToReplace.Key] = replaceFromPosition.Value;

                    PyramidPositions[replaceFromPosition.Key] = null;

                }

                if (!tilesMoved)
                {
                    var tempTopTile = TopTile;
                    TopTile = BottomTile;
                    BottomTile = tempTopTile;
                    tilesMoved = true;
                    BottomTile.FlipDirection();
                }

                if (PyramidPositions.Any(x => x.Value == null))
                {
                    UpdatePositions(PyramidPositions.FirstOrDefault(x => x.Value == null).Key);
                }
            }
            #endregion
        }
    }
}
