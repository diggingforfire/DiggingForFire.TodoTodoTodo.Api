using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiggingForFire.TTT.Application.Interfaces;
using DiggingForFire.TTT.DataAccess;
using DiggingForFire.TTT.Domain;
using Microsoft.EntityFrameworkCore;

namespace DiggingForFire.TTT.Application.Services
{
    public class TodoService : ITodoService
    {
        private readonly ITodoContext _todoContext;

        public TodoService(ITodoContext todoContext)
        {
            _todoContext = todoContext ?? throw new ArgumentNullException(nameof(todoContext));
        }

        public async Task<IReadOnlyCollection<Todo>> GetTodosAsync()
        {
            var queryable =
                from todo in _todoContext.Todos
                select todo;

            var todos = await queryable.ToListAsync().ConfigureAwait(false);

            return todos.AsReadOnly();
        }
    }
}
    