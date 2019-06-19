
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DiggingForFire.TodoTodoTodo.Application.Models;

namespace DiggingForFire.TodoTodoTodo.Application.Interfaces
{
    public interface ITodoService
    {
        Task<IReadOnlyCollection<Todo>> GetTodosAsync();
    }
}
