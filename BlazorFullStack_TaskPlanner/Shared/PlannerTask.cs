using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFullStack_TaskPlanner.Shared
{
    public class PlannerTask
    {
        public int TaskId { get; set; }
        public string? TaskName { get; set; }
        public string? Description { get; set; }
        public PlannerTaskStatus? Status { get; set; }
    }
}
