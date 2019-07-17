using System.Collections.Generic;
using System.Threading.Tasks;
using DiggingForFire.TTT.Domain;

namespace DiggingForFire.TTT.Application.Interfaces
{
    public interface ITodoService
    {
        Task<IReadOnlyCollection<Todo>> GetTodosAsync();
    }
}
