using System.Collections.Generic;

namespace Teotibot.Core.Store
{
    public interface IReadStore<out T>
    {
        IEnumerable<T> GetAll();
    }
}
