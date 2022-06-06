namespace RepositoryPatternWithUnitOfWork.Core
{
    public class Book : BaseEntity
    {
        [Required, MaxLength(250)]
        public string? Title { get; set; }
        public Author? Author { get; set; }
    }
}
