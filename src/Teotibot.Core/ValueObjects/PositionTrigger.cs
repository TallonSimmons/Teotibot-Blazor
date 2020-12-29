using System;
using System.Collections.Generic;
using System.Linq;

namespace Teotibot.Core.ValueObjects
{
    public record PositionTrigger
    {
        public PositionTrigger(List<int> triggerNumbers)
        {
            if (triggerNumbers == null)
            {
                throw new ArgumentNullException();
            }

            if (triggerNumbers.Any(x => x < 2 || x > 12)
                || triggerNumbers.Count <= 0
                || triggerNumbers.Count > 3)
            {
                throw new ArgumentOutOfRangeException();
            }

            TriggerNumbers = triggerNumbers;
        }
        public List<int> TriggerNumbers { get; }
    }
}
