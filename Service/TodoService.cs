using TodoAPI.DB.Access;
using TodoAPI.Models;
using TodoAPI.DB.Entities;

namespace TodoAPI.Service
{
    public class TodoService
    {

        private readonly TodoAccess _todoAccess;
        public TodoService(TodoAccess todoAccess)
        {
            _todoAccess = todoAccess;
        }

        public List<Todo> GetAll()
        {
            return _todoAccess.GetAll();
        }

        public int AddTodo(Todo todo)
        {
            if(todo == null) return 0;
            return _todoAccess.Add(todo);
  
        }

        public Todo FindById(int id)
        {
            return _todoAccess.FindById(id);
        }
        public int Delete(int id) {

            return _todoAccess.Delete(id);
        }
    }
}
