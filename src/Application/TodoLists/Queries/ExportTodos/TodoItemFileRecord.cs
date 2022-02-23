using VerseChallenge.Application.Common.Mappings;
using VerseChallenge.Domain.Entities;

namespace VerseChallenge.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
