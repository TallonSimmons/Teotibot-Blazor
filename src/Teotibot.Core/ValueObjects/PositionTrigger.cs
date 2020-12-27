using System;
using System.Collections.Generic;
using System.Linq;

namespace Teotibot.Core.ValueObjects
{
    public class PositionTrigger
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

        public override bool Equals(object obj)
        {
            return TriggerNumbers
                .All(x => ((PositionTrigger)obj).TriggerNumbers
                .Any(y => x == y));
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(TriggerNumbers);
        }

        public static bool operator ==(PositionTrigger a, PositionTrigger b) => a?.Equals(b) ?? false;
        public static bool operator !=(PositionTrigger a, PositionTrigger b) => !a?.Equals(b) ?? true;
    }
}
