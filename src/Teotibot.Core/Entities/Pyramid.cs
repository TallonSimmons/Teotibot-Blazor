﻿using System;
using System.Collections.Generic;
using System.Linq;
using Teotibot.Core.Entities.PyramidTiles;
using Teotibot.Core.Extensions;
using Teotibot.Core.ValueObjects;

namespace Teotibot.Core.Entities
{
    public class Pyramid
    {
        private readonly Dictionary<PyramidPosition, PyramidTile> pyramidPositions = new Dictionary<PyramidPosition, PyramidTile>();

        public Pyramid(IEnumerable<PyramidTile> tiles)
        {
            if (tiles is null)
            {
                throw new ArgumentNullException(nameof(tiles));
            }

            if (tiles.Count() != 6)
            {
                throw new ArgumentOutOfRangeException();
            }

            var shuffledTiles = tiles.Shuffle().ToList();
            for (int i = 0; i < 6; i++)
            {
                var currentTile = shuffledTiles[i];
                currentTile.PyramidPosition = new PyramidPosition(i + 1);
                pyramidPositions.Add(currentTile.PyramidPosition, currentTile);
            }
        }

        public bool HasEmptyPyramidPositions => pyramidPositions.Any(x => x.Value == null);

        public PyramidTile ActivateTile(TileRoll tileRoll)
        {
            var targetedPyramidPosition = pyramidPositions
                .FirstOrDefault(p => p.Key.GetPositionTrigger()?.TriggerNumbers.Contains(tileRoll.Result) ?? false);

            var triggeredPyramidPosition = targetedPyramidPosition.Key;
            var activatedTile = targetedPyramidPosition.Value;

            pyramidPositions[targetedPyramidPosition.Key] = null;

            return activatedTile;
        }

        public void FillNextEmptyPyramidPosition(DirectionTile directionTile, PyramidTile setAsideTile)
        {
            var positionToReplace = pyramidPositions.FirstOrDefault(x => x.Value == null);

            var replacementPositionNumber = positionToReplace.Key.GetReplacementPosition(directionTile.Direction);
            var replaceFromPosition = pyramidPositions.FirstOrDefault(x => x.Key.Position == replacementPositionNumber);

            if (replacementPositionNumber == 0)
            {
                pyramidPositions[positionToReplace.Key] = setAsideTile;
            }
            else
            {
                pyramidPositions[positionToReplace.Key] = replaceFromPosition.Value;

                pyramidPositions[replaceFromPosition.Key] = null;
            }
        }
    }
}
