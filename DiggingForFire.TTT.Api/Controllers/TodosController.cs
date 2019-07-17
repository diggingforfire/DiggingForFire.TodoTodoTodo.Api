using System;
using System.Threading.Tasks;
using DiggingForFire.TTT.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DiggingForFire.TTT.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoService _todoService;

        public TodosController(ITodoService todoService)
        {
            _todoService = todoService ?? throw new ArgumentNullException(nameof(todoService));
        }
 
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var todos = await _todoService.GetTodosAsync();

            return new OkObjectResult(todos);
        }
    }
}
