using Microsoft.EntityFrameworkCore;
using Teotibot.Infrastructure.DataModels;

namespace Teotibot.Infrastructure.Contexts
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext()
        {
            Database.EnsureCreated();
        }
        internal DbSet<GameData> Games { get; set; }
    }
}
