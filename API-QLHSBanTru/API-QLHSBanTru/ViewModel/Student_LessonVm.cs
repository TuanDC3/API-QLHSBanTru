namespace API_QLHSBanTru.ViewModel
{
    public class Student_LessonVm
    {
        public int LessonID { get; set; }
        public int StudentID { get; set; }
        public bool Rating { get; set; }
        public bool Status { get; set; }

        public virtual LessonVm Lesson { get; set; }
        public virtual StudentVm Student { get; set; }
    }
}