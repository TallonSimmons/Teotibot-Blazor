using System;
using System.ComponentModel.DataAnnotations;
using Teotibot.Core.Entities;
using Teotibot.Core.Entities.Tiles;
using Teotibot.Core.Entities.Tiles.PyramidTiles;
using Teotibot.Core.ValueObjects;

namespace Teotibot.Infrastructure.DataModels
{
    internal class GameData
    {
        [Key]
        public Guid Id { get; set; }
        public Pyramid Pyramid { get; set; }
        public PyramidTile ActiveTile { get; set; }
        public PyramidTile SetAsideTile { get; set; }
        public DirectionTile TopDirectionTile { get; set; }
        public DirectionTile BottomDirectionTile { get; set; }
    }

    internal static class GameDataTransformations
    {
        internal static Game ToGame(this GameData gameData)
        {
            return new Game(
                gameData.Id,
                gameData.Pyramid,
                gameData.SetAsideTile,
                gameData.TopDirectionTile,
                gameData.BottomDirectionTile,
                gameData.ActiveTile);
        }

        internal static GameData FromGame(this Game game)
        {
            return new GameData
            {
                Id = game.Id,
                Pyramid = game.Pyramid,
                ActiveTile = game.ActiveTile,
                SetAsideTile = game.SetAsideTile,
                TopDirectionTile = game.TopDirectionTile,
                BottomDirectionTile = game.BottomDirectionTile
            };
        }
    }
}
