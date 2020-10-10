using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teotibot.Core.DataModels;
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

        public async Task SaveChangesAsync<T>(T entity)
            where T : class, IDataModel
        {
            var result = await context.SaveChangesAsync();
        }

        public IAsyncEnumerable<T> StreamAllAsync<T>(Func<T, bool> predicate) 
            where T : class, IDataModel
        {
            return context
                .Set<T>()
                .Where(predicate)
                .AsQueryable()
                .AsAsyncEnumerable();
        }
    }
}
