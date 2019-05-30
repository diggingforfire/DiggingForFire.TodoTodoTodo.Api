using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DiggingForFire.TodoTodoTodo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await Task.Delay(20);

            return new OkObjectResult("1");
        }
    }
}
