using System.Threading.Tasks;
using Teotibot.Core.Repositories.Results;

namespace Teotibot.Core.Repositories
{
    public interface IWriteRepository
    {
        public Task<ISavedChangesResult> SaveChangesAsync();
        public Task<ISavedChangesResult> CreateOrUpdateAsync<T>(T entity);
    }
}
