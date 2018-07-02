using System.Collections.Generic;

namespace API_QLHSBanTru.ViewModel
{
    public class WeeklyTaskVm
    {
        public int WeeklyTaskID { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<DailyTaskVm> DailyTasks { get; set; }
    }
}