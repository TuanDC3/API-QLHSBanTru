using System.Collections.Generic;

namespace API_QLHSBanTru.ViewModel
{
    public class SemesterVm
    {
        public int SemesterID { get; set; }
        public int CourseID { get; set; }
        public string Name { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public bool Status { get; set; }

        public virtual CourseVm Course { get; set; }
        public virtual ICollection<GradeVm> Grades { get; set; }
    }
}