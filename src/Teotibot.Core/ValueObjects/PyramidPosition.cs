using System;
using System.Collections.Generic;
using Teotibot.Core.Enums;

namespace Teotibot.Core.ValueObjects
{
    public class PyramidPosition
    {
        private readonly Dictionary<ReplacementDirection, Dictionary<int, int>> replacementMap = new Dictionary<ReplacementDirection, Dictionary<int, int>>
        {
            {
                ReplacementDirection.Left, new Dictionary<int, int>
                {
                    {1, 3},
                    {2, 5},
                    {3, 6}
                }
            },
            {
                ReplacementDirection.Right, new Dictionary<int, int>
                {
                    {1, 2},
                    {2, 4},
                    {3, 5}
                }
            }
        };

        private readonly Dictionary<int, PositionTrigger> triggerMap = new Dictionary<int, PositionTrigger>
        {
            {1, new PositionTrigger(new List<int>{6,7,8})},
            {2, new PositionTrigger(new List<int>{4,5})},
            {3, new PositionTrigger(new List<int>{9,10})},
            {4, new PositionTrigger(new List<int>{2,3})},
            {6, new PositionTrigger(new List<int>{11,12})},
        };

        public PyramidPosition(int position)
        {
            if (position < 1 || position > 6)
            {
                throw new ArgumentOutOfRangeException();
            }

            Position = position;
        }

        public int Position { get; }

        public int GetReplacementPosition(ReplacementDirection replacementDirection)
        {
            if (replacementMap[replacementDirection].TryGetValue(Position, out var replacement))
            {
                return replacement;
            };

            return 0;
        }

        public PositionTrigger GetPositionTrigger()
        {
            if(triggerMap.TryGetValue(Position, out var trigger))
            {
                return trigger;
            }

            return null;
        }
    }
}
