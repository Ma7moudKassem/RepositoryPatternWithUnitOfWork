namespace RepositoryPatternWithUnitOfWork.Core
{
    public class BaseEntity
    {
        public int Id { get; set; }

        [Required,MaxLength(100)]
        public string? Name { get; set; }
    }
}
