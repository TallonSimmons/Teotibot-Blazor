using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teotibot.Core.Repositories;
using Teotibot.Infrastructure.Contexts;
using Teotibot.Infrastructure.Models;

namespace Teotibot.Infrastructure.Repositories
{
    internal class EntityFrameworkRepository : IReadRepository, IWriteRepository
    {
        private readonly AppDbContext context;

        public EntityFrameworkRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<ISavedChangesResult> SaveChangesAsync()
        {
            var result = await context.SaveChangesAsync();

            return new SavedChangesResult(result);
        }

        public IAsyncEnumerable<T> StreamAllAsync<T>(Func<T, bool> predicate)
            where T : class
        {
            return context
                .Set<T>()
                .Where(predicate)
                .AsQueryable()
                .AsAsyncEnumerable();
        }
    }
}
