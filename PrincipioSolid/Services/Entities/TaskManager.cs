using System.Collections.Generic;
using System.Linq;

public class TaskManager
{
    private List<Task> tasks = new List<Task>();

    public void AddTask(Task task)
    {
        tasks.Add(task);
    }

    public List<Task> GetAllTasks()
    {
        return tasks;
    }

    public List<Task> FilterByPriority(string priority)
    {
        return tasks.Where(t => t.Priority.ToLower() == priority.ToLower()).ToList();
    }
}
