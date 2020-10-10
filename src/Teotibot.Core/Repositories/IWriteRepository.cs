using System.Threading.Tasks;
using Teotibot.Core.DataModels;

namespace Teotibot.Core.Repositories
{
    public interface IWriteRepository
    {
        public Task SaveChangesAsync<T>(T entity)
            where T : class, IDataModel;
    }
}
