using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Teotibot.Core.Repositories
{
    public interface IReadRepository
    {
        public Task<IAsyncEnumerable<T>> StreamAllAsync<T>(Func<bool> predicate);
    }
}
