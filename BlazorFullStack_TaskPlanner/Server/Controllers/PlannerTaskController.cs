using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorFullStack_TaskPlanner.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlannerTaskController : ControllerBase
    {
        private static List<PlannerTaskStatus> statuses = new List<PlannerTaskStatus>
        {
            new PlannerTaskStatus{ StatusId = 1, Status = "Not started"},
            new PlannerTaskStatus{ StatusId = 2, Status = "Ongoing"},
            new PlannerTaskStatus{ StatusId = 3, Status =  "Completed"}
        };

        public List<PlannerTask> tasks = new List<PlannerTask>
        {
            new PlannerTask{TaskId = 1, TaskName = "Plan dinners", Description = "Set up a weekly dinner plan.", Status = statuses[0]},
            new PlannerTask{TaskId = 2, TaskName = "Do homework", Description = "Do this week's coding exercises", Status = statuses[1]},
            new PlannerTask{TaskId = 3, TaskName = "Do the laundry", Description = "Wash clothes and hang them to dry", Status = statuses[2]}
        };

        public async Task<ActionResult<List<PlannerTask>>> GetAllTasks()
        {
           return Ok(tasks);
        }
    }
}
