using Teotibot.Core.Enums;
using Teotibot.Core.ValueObjects;
using Xunit;

namespace Teotibot.Core.UnitTests.ValueObjects.PyramidPositionTests
{
    public class PyramidPositionShould
    {
        [Theory]
        [InlineData(ReplacementDirection.Left, 4)]
        [InlineData(ReplacementDirection.Left, 5)]
        [InlineData(ReplacementDirection.Left, 6)]
        [InlineData(ReplacementDirection.Right, 4)]
        [InlineData(ReplacementDirection.Right, 5)]
        [InlineData(ReplacementDirection.Right, 6)]
        public void Return_Zero_For_Position_That_Cannot_Be_Replaced(ReplacementDirection replacementDirection, int position)
        {
            var pyramidPosition = new PyramidPosition(position);
            var expected = 0;
            var actual = pyramidPosition.GetReplacementPosition(replacementDirection);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(ReplacementDirection.Left, 1, 3)]
        [InlineData(ReplacementDirection.Left, 2, 5)]
        [InlineData(ReplacementDirection.Left, 3, 6)]
        [InlineData(ReplacementDirection.Right, 1, 2)]
        [InlineData(ReplacementDirection.Right, 2, 4)]
        [InlineData(ReplacementDirection.Right, 3, 5)]
        public void Return_Correct_Replacement_For_Direction_And_Position(ReplacementDirection replacementDirection, int position, int expected)
        {
            var pyramidPosition = new PyramidPosition(position);

            var actual = pyramidPosition.GetReplacementPosition(replacementDirection);

            Assert.Equal(expected, actual);
        }
    }
}
