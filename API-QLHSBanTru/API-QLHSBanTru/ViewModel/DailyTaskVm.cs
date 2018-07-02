namespace API_QLHSBanTru.ViewModel
{
    public class DailyTaskVm
    {
        public int DailyTaskID { get; set; }
        public int StudentID { get; set; }
        public int WeeklyTaskID { get; set; }
        public int MonthlyTaskID { get; set; }
        public System.DateTime DateTask { get; set; }
        public bool Present { get; set; }
        public string Reason { get; set; }
        public System.TimeSpan DrugTime { get; set; }
        public double EatRating { get; set; }
        public double SleepRating { get; set; }
        public double HealthRating { get; set; }
        public double StudyRating { get; set; }
        public System.TimeSpan PickTime { get; set; }
        public string Note { get; set; }
        public bool Status { get; set; }

        public virtual PhysicalMonthlyTaskVm PhysicalMonthlyTask { get; set; }
        public virtual StudentVm Student { get; set; }
        public virtual WeeklyTaskVm WeeklyTask { get; set; }
    }
}