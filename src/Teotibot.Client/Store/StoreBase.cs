using System;

namespace Teotibot.Client.Store
{
    public abstract class StoreBase
    {
        public StoreBase()
        {
            OnStoreMutated?.Invoke();
        }

        public event Action OnStoreMutated;
    }
}
