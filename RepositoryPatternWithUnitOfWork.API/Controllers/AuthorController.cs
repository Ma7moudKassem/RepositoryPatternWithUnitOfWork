namespace RepositoryPatternWithUnitOfWork.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IBaseRepository<Author> _authorRepository;

        public AuthorController(IBaseRepository<Author> authorRepository)
        {
            _authorRepository = authorRepository;
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var responce = _authorRepository.GetById(1);
            return Ok(responce);
        }
    }
}
