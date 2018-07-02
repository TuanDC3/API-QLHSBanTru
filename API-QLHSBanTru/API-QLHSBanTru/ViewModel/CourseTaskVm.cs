namespace API_QLHSBanTru.ViewModel
{
    public class CourseTaskVm
    {
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public double PhysicalRating { get; set; }
        public double StudyRating { get; set; }
        public double TotalRating { get; set; }
        public bool Passes { get; set; }
        public string Note { get; set; }
        public bool Status { get; set; }

        public virtual CourseVm Course { get; set; }
        public virtual StudentVm Student { get; set; }
    }
}