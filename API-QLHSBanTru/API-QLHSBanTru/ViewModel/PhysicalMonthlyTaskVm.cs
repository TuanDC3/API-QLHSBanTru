using System.Collections.Generic;

namespace API_QLHSBanTru.ViewModel
{
    public class PhysicalMonthlyTaskVm
    {
        public int PhysicalMonthlyTaskID { get; set; }
        public int StudentID { get; set; }
        public string Note { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string HeightRating { get; set; }
        public string WeightRating { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<DailyTaskVm> DailyTasks { get; set; }
    }
}