using System.Collections.Generic;

namespace API_QLHSBanTru.ViewModel
{
    public class CourseVm
    {
        public int CourseID { get; set; }
        public string Name { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<CourseTaskVm> CourseTasks { get; set; }
        public virtual ICollection<SemesterVm> Semesters { get; set; }
    }
}