namespace BlazorFullStack_TaskPlanner.Client.Services.TaskPlannerService
{
    public interface ITaskPlannerService
    {
        List<PlannerTask> tasks { get; set; }
        Task GetAllTasks();
    }
}
