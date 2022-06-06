using RepositoryPatternWithUnitOfWork.Core;

namespace RepositoryPatternWithUnitOfWork.EF.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
