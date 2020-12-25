using Microsoft.EntityFrameworkCore;
using Teotibot.Core.Entities;

namespace Teotibot.Infrastructure.Contexts
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
    }
}
