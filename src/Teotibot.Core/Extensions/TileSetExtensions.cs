using System;
using Teotibot.Core.Enums;

namespace Teotibot.Core.Extensions
{
    public static class TileSetExtensions
    {
        public static string GetTileSetName(this TileSet expansion)
        {
            return expansion switch
            {
                TileSet.BaseGame => "Base",
                TileSet.LatePreClassicPeriod => "Late Pre-Classic Period",
                TileSet.ShadowsOfXitle => "Shadows Of Xitle",
                _ => throw new ArgumentOutOfRangeException(),
            };
        }
    }
}
