using System;
using System.Collections.Generic;
using System.Linq;
using Teotibot.Core.Entities.Tiles;
using Teotibot.Core.Entities.Tiles.PyramidTiles;
using Teotibot.Core.Extensions;
using Teotibot.SharedKernel.Extensions;

namespace Teotibot.Core.ValueObjects
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

        internal PyramidTile ActivateTile(TileRoll tileRoll)
        {
            var targetedPyramidPosition = pyramidPositions
                .FirstOrDefault(p => p.Key.GetPositionTrigger()?.TriggerNumbers.Contains(tileRoll.Result) ?? false);

            var triggeredPyramidPosition = targetedPyramidPosition.Key;
            var activatedTile = targetedPyramidPosition.Value;

            pyramidPositions[targetedPyramidPosition.Key] = null;

            return activatedTile;
        }

        internal void FillNextEmptyPyramidPosition(DirectionTile directionTile, PyramidTile setAsideTile)
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

        public override bool Equals(object obj)
        {
            var other = ((Pyramid)obj);
            return other?.HasEmptyPyramidPositions == HasEmptyPyramidPositions 
                && other.pyramidPositions.ContentEquals(pyramidPositions);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(pyramidPositions, HasEmptyPyramidPositions);
        }

        public static bool operator ==(Pyramid a, Pyramid b) => a?.Equals(b) ?? false;
        public static bool operator !=(Pyramid a, Pyramid b) => !a?.Equals(b) ?? true;
    }
}
