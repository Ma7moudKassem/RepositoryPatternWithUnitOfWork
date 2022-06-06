namespace RepositoryPatternWithUnitOfWork.EF
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly DataContext _context;

        public BaseRepository(DataContext context)
        {
            _context = context;
        }
        public  TEntity  GetById(int id)=>  _context.Set<TEntity>().Find(id);

    }
}
