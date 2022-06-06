namespace RepositoryPatternWithUnitOfWork
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        TEntity GetById(int id);
        
    }
}
