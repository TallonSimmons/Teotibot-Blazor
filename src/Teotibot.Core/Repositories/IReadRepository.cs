using System;
using System.Collections.Generic;

namespace Teotibot.Core.Repositories
{
    public interface IReadRepository
    {
        IAsyncEnumerable<T> FindAsyncStream<T>(Func<T, bool> predicate) where T : class;
        IAsyncEnumerable<T> GetAllAsyncStream<T>() where T : class;
    }
}
