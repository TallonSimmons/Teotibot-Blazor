using System;
using Teotibot.Core.Store;

namespace Teotibot.Client.Store
{
    public abstract class StateBase : IStateProvider
    {
        public StateBase()
        {
            OnStoreMutated?.Invoke();
        }

        public event Action OnStoreMutated;
    }
}
