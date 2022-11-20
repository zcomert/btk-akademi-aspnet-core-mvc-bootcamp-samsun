using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositories.EFCore
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
            : base(options)
        {

        }
    }
}
