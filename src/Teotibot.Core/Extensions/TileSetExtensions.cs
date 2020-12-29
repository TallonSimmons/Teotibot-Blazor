using System;
using Teotibot.Core.Enums;

namespace Teotibot.Core.Extensions
{
    public static class TileSetExtensions
    {
        public static string GetTileSetName(this Set expansion)
        {
            return expansion switch
            {
                Set.BaseGame => "Base",
                Set.LatePreClassicPeriod => "LPP",
                Set.ShadowsOfXitle => "SoX",
                _ => throw new ArgumentOutOfRangeException(),
            };
        }
    }
}
