using Teotibot.Core.Enums;

namespace Teotibot.Core.Entities.Tiles
{
    public class PriestTile : Tile
    {
        public PriestTile(string title, PriestTileType priestTileType) : base(title, Set.LatePreClassicPeriod, TileType.PriestTile)
        {
            PriestTileType = priestTileType;
        }

        public PriestTileType PriestTileType { get; }
    }
}
