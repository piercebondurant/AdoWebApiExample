using AdoWebApiExample.Repositories.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AdoWebApiExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExampleController : ControllerBase
    {
        private readonly ILogger<ExampleController> _logger;
        private readonly ExampleRepository _myRepository;

        public ExampleController(ILogger<ExampleController> logger, ExampleRepository myRepository)
        {
            _logger = logger;
            _myRepository = myRepository;
        }

        [HttpGet(Name = "Create")]
        public async Task<IActionResult> Create()
        {
            return new OkObjectResult(await _myRepository.Create());
        }
    }
}
