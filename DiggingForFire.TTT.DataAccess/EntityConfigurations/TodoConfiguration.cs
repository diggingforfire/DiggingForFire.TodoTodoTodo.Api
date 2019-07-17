using DiggingForFire.TTT.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DiggingForFire.TTT.DataAccess.EntityConfigurations
{
    public class TodoConfiguration : IEntityTypeConfiguration<Todo>
    {
        public void Configure(EntityTypeBuilder<Todo> builder)
        {
            builder.HasKey(todo => todo.Id);
            builder.Property(todo => todo.Description).IsRequired();
        }
    }
}
