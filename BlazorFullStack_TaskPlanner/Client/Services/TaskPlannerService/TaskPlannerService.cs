using System.Net.Http.Json;

namespace BlazorFullStack_TaskPlanner.Client.Services.TaskPlannerService
{
    public class TaskPlannerService : ITaskPlannerService
    {
        private readonly HttpClient _httpClient;

        public TaskPlannerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public List<PlannerTask> tasks { get; set; } = new List<PlannerTask>();

        public async Task GetAllTasks()
        {
            var result = await _httpClient.GetFromJsonAsync<List<PlannerTask>>("api/plannertask");
            if(result != null)
            {
                tasks = result;
            }
        }
    }
}
