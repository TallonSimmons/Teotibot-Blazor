using Teotibot.Core.Enums;

namespace Teotibot.Core.DataModels
{
    public class TileData : IDataModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public TileSet TileSet { get; set; }
    }
}
