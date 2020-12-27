using Teotibot.Core.Repositories.Results;

namespace Teotibot.Infrastructure.Models
{
    internal sealed class SavedChangesResult : ISavedChangesResult
    {
        internal SavedChangesResult(int numberOfChangesSaved)
        {
            NumberOfChangesSaved = numberOfChangesSaved;
        }

        public int NumberOfChangesSaved { get; }
    }
}
