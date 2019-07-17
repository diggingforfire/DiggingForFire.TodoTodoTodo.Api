using DiggingForFire.TTT.Domain;
using Microsoft.EntityFrameworkCore;

namespace DiggingForFire.TTT.DataAccess
{
    public interface ITodoContext
    {
        DbSet<Todo> Todos { get; set; }
    }
}
