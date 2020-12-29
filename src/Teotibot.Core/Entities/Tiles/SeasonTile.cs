using Teotibot.Core.Enums;

namespace Teotibot.Core.Entities.Tiles
{
    public class SeasonTile : Tile
    {
        public SeasonTile(string title) : base(title, Set.LatePreClassicPeriod, TileType.SeasonTile)
        {
        }
    }
}
