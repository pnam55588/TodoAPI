using TodoAPI.DB.Entities;

namespace TodoAPI.DB.Access
{
    public class TodoAccess
    {
        protected readonly DataContext _context;
        public TodoAccess(DataContext context)
        {
            _context = context;
        }

        public TodoAccess() { }

        public List<Todo> GetAll() {
            return _context.Todos.ToList();
        }
        public Todo FindById(int id)
        {
            return _context.Todos.Where(Todo=> Todo.Id == id).First();
        }
        public int Add(Todo todo) { 
            _context.Todos.Add(todo);
            int numsOfInserted = _context.SaveChanges();
            return numsOfInserted;
        }
        public int Delete(int id) {
            // Find the Todo item with the given id
            var todoToDelete = _context.Todos.FirstOrDefault(todo => todo.Id == id);

            if (todoToDelete != null)
            {
                // Remove the Todo item from the context
                _context.Todos.Remove(todoToDelete);

                // Save changes to the database
                int numsOfDeleted = _context.SaveChanges();

                // Return 1 to indicate that the deletion was successful
                return numsOfDeleted;
            }
            else
            {
                // Return 0 to indicate that no item was found and deleted
                return 0;
            }
        }
    }
}
