using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teotibot.Core.Repositories;
using Teotibot.Core.Repositories.Results;
using Teotibot.Infrastructure.Contexts;
using Teotibot.Infrastructure.Models;

namespace Teotibot.Infrastructure.Repositories
{
    internal sealed class EntityFrameworkRepository : IRepository
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

        public async Task<ISavedChangesResult> CreateOrUpdate<T>(T entity)
        {
            try
            {
                context.Add(entity);
            }
            catch (Exception)
            {
                context.Update(entity);
            }

            return await SaveChangesAsync();
        }

        public IAsyncEnumerable<T> FindAsyncStream<T>(Func<T, bool> predicate)
            where T : class
        {
            return context
                .Set<T>()
                .Where(predicate)
                .AsQueryable()
                .AsAsyncEnumerable();
        }

        public IAsyncEnumerable<T> GetAllAsyncStream<T>() where T : class
        {
            return context.Set<T>().AsAsyncEnumerable();
        }

        public T FindSingle<T>(Func<T, bool> predicate) where T : class
        {
            return context.Set<T>().FirstOrDefault(predicate);
        }
    }
}
