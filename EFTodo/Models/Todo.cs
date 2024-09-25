public class Todo
{
    public int Id{get;set;}
    public string Task{get; set;}
    public bool Completed {get; set;}

    public Todo(string task, bool completed)
    {
        Task=task;
        Completed=completed;
    }

    
}