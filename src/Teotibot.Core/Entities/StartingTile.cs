﻿using Teotibot.Core.Enums;

namespace Teotibot.Core.Entities
{
    public class StartingTile : Tile
    {
        public StartingTile(string title, TileSet tileSet) : base(title, tileSet, TileType.StartingTile)
        {
        }
    }
}
