using System.Collections.Generic;

namespace API_QLHSBanTru.ViewModel
{
    public class GradeVm
    {
        public int GradeID { get; set; }
        public int SemesterID { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<ClassVm> Classes { get; set; }
        public virtual SemesterVm Semester { get; set; }
    }
}