using System.Threading.Tasks;

namespace Teotibot.Core.Repositories
{
    public interface IWriteRepository
    {
        public Task<ISavedChangesResult> SaveChangesAsync();
    }
}
