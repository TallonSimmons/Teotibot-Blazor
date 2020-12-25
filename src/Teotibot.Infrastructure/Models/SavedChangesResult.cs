using System;
using Teotibot.Core.Repositories;

namespace Teotibot.Infrastructure.Models
{
    internal class SavedChangesResult : ISavedChangesResult
    {
        public SavedChangesResult(int numberOfChangesSaved)
        {
            NumberOfChangesSaved = numberOfChangesSaved;
        }
        public int NumberOfChangesSaved { get; }
    }
}
