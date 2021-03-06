using Microsoft.EntityFrameworkCore;

namespace webAPIdot.Models {
    public class TodoContext: DbContext {
        public TodoContext(DbContextOptions options) 
        : base(options) {

        }

        public DbSet<TodoItemDTO> TodoItems {get;set;}
    }
}