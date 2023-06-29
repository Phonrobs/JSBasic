using Microsoft.AspNetCore.Mvc;
using TodoBackend.Contracts.TodoItem;

namespace TodoBackend.Controllers.TodoItems;

[ApiController]
public class TodoItemsController : ControllerBase
{
    [HttpPost("/api/todoitems")]
    public IActionResult CreateItem(CreateTodoItemRequest request) {
        return Ok(request);
    }
}