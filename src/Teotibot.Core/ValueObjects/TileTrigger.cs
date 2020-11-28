using System;
using System.Collections.Generic;
using System.Linq;

namespace Teotibot.Core.ValueObjects
{
    public class TileTrigger
    {
        public TileTrigger(List<int> triggerNumbers)
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

        public override bool Equals(object obj)
        {
            return TriggerNumbers
                .All(x => ((TileTrigger)obj).TriggerNumbers
                .Any(y => x == y));
        }
    }
}
