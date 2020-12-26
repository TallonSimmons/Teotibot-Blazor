using Teotibot.Core.Enums;

namespace Teotibot.Core.Entities
{
    public class SeasonTile : Tile
    {
        public SeasonTile(string title) : base(title, TileSet.LatePreClassicPeriod, TileType.SeasonTile)
        {
        }
    }
}
