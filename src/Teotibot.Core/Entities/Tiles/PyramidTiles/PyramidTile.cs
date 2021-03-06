﻿using Teotibot.Core.Entities.Tiles;
using Teotibot.Core.Enums;
using Teotibot.Core.ValueObjects;

namespace Teotibot.Core.Entities.Tiles.PyramidTiles
{
    public class PyramidTile : Tile
    {
        public PyramidTile(string title, Set tileSet, string instructions) : base(title, tileSet, TileType.PyramidTile)
        {
            Instructions = instructions;
        }

        public PyramidPosition PyramidPosition { get; set; }
        public string Instructions { get; }
    }
}
