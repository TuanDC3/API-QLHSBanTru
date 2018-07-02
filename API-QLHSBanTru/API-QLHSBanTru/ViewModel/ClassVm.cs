using System.Collections.Generic;

namespace API_QLHSBanTru.ViewModel
{
    public class ClassVm
    {
        public int ClassID { get; set; }
        public int GradeID { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }

        public virtual GradeVm Grade { get; set; }
        public virtual ICollection<Employee_ClassVm> Employee_Class { get; set; }
        public virtual ICollection<Student_ClassVm> Student_Class { get; set; }
    }
}