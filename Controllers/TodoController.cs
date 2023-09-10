using Microsoft.AspNetCore.Mvc;
using TodoAPI.Service;
using TodoAPI.Models;
using TodoAPI.DB.Entities;

namespace TodoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly TodoService _todoService;
        public TodoController(TodoService todoService) {
            _todoService = todoService;

        }

        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(_todoService.GetAll());
        }
        [HttpPost]
        public ActionResult AddTodo(Todo todo) {
            return Ok(_todoService.AddTodo(todo));
        }
        [HttpGet("{id}")]
        public ActionResult FindOne(int id)
        {
            return Ok(_todoService.FindById(id));
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(_todoService.Delete(id));
        }
    }
}
