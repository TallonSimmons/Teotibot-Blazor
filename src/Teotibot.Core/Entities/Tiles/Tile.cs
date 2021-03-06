﻿using Teotibot.Core.Enums;
using Teotibot.Core.ValueObjects;

namespace Teotibot.Core.Entities.Tiles
{
    public class Tile : Entity<TileIdentifier>
    {
        public Tile(string title, Set tileSet, TileType tileType) : base(new TileIdentifier(title, tileSet, tileType))
        {
            Image = new TileImage(title, tileSet, tileType);
            TileSet = tileSet;
            TileType = tileType;
        }


        public TileImage Image { get; }
        public Set TileSet { get; }
        public TileType TileType { get; }
    }
}
