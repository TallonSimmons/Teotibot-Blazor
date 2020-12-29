using Teotibot.Core.UnitTests.Shared.Fixtures;
using Teotibot.Core.ValueObjects;
using Xunit;

namespace Teotibot.Core.UnitTests.ValueObjects.SetupTests
{
    public class SetupShouldNot : IClassFixture<SetupFixture>
    {
        private readonly SetupFixture fixture;

        public SetupShouldNot(SetupFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void Throw_Exception_When_Setup_Valid()
        {
            // Assert no exception thrown
            new Setup(
                fixture.GameTestFixture.EverythingOnGameSettings,
                fixture.ValidBaseGameRoyalTiles,
                fixture.ValidBaseGameStartingTiles,
                fixture.ValidPriestTiles,
                fixture.ValidBaseGameTechnologyTiles,
                fixture.ValidSeasonTiles);
        }
    }
}
