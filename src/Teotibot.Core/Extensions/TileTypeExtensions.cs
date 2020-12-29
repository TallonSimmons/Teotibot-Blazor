using System;
using Teotibot.Core.Enums;

namespace Teotibot.Core.Extensions
{
    public static class TileTypeExtensions
    {
        public static string GetTileTypeName(this TileType tileType)
        {
            return tileType switch
            {
                TileType.PyramidTile => "Pyramid",
                TileType.RoyalTile => "Royal",
                TileType.StartingTile => "Starting",
                TileType.TechnologyTile => "Technology",
                TileType.SeasonTile => "Season",
                TileType.PriestTile => "Priest",
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}