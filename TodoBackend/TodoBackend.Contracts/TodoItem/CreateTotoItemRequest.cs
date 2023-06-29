namespace TodoBackend.Contracts.TodoItem;

public class CreateTodoItemRequest
{
    public string Name { get; set; }
    public string Detail { get; set; }
    public bool Complete { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public List<string> CheckList { get; set; }
}