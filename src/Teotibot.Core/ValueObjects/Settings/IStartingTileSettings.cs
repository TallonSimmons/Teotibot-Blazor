namespace Teotibot.Core.ValueObjects.Settings
{
    public interface IStartingTileSettings : ISettings
    {
        bool IncludeStartingTiles { get; }
    }
}
