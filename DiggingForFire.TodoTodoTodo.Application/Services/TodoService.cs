using System.Collections.Generic;
using System.Threading.Tasks;
using DiggingForFire.TodoTodoTodo.Application.Interfaces;
using DiggingForFire.TodoTodoTodo.Application.Models;

namespace DiggingForFire.TodoTodoTodo.Application.Services
{
    public class TodoService : ITodoService
    {
        public async Task<IReadOnlyCollection<Todo>> GetTodosAsync()
        {
            await Task.Delay(20);

            var list = (IReadOnlyCollection<Todo>)new List<Todo>(new []
            {
                new Todo { Title = "Boodschapjes doen", Description = "Op zaterdag" },
                new Todo { Title = "Cd's opruimen", Description = "Misschien nog wat bewaren" }
            }).AsReadOnly();

            return list;
        }
    }
}
    