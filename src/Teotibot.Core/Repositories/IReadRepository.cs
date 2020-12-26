using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Teotibot.Core.Repositories
{
    public interface IReadRepository
    {
        IAsyncEnumerable<T> FindAsyncStream<T>(Func<T, bool> predicate) where T : class;
        IAsyncEnumerable<T> GetAllAsyncStream<T>() where T : class;
        T FindSingle<T>(Func<T, bool> predicate) where T : class;
    }
}
