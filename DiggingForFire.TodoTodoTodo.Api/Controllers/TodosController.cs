using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DiggingForFire.TodoTodoTodo.Application.Interfaces;

namespace DiggingForFire.TodoTodoTodo.Api.Controllers
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
