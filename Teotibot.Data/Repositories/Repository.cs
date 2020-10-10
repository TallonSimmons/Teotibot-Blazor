using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Teotibot.Core.Repositories;
using Teotibot.Data.Contexts;

namespace Teotibot.Data.Repositories
{
    internal class Repository : IReadRepository, IWriteRepository
    {
        private readonly AppDbContext context;

        public Repository(AppDbContext context)
        {
            this.context = context;
        }

        public Task SaveChangesAsync<T>()
        {
            throw new NotImplementedException();
        }

        public Task<IAsyncEnumerable<T>> StreamAllAsync<T>(Func<bool> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
