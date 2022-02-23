using VerseChallenge.Application.TodoLists.Queries.ExportTodos;

namespace VerseChallenge.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
