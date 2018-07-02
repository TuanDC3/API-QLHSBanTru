using System;
using System.Collections.Generic;

namespace API_QLHSBanTru.ViewModel
{
    public class StudentVm
    {
        public int StudentID { get; set; }
        public string StudentCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomeName { get; set; }
        public System.DateTime Birthday { get; set; }
        public bool Gender { get; set; }
        public byte[] Image { get; set; }
        public string Hobby { get; set; }
        public string Talent { get; set; }
        public int EthnicGroupID { get; set; }
        public int ReligionID { get; set; }
        public int BirthPlaceID { get; set; }
        public int LocationID { get; set; }
        public string AdressDetail { get; set; }
        public Nullable<int> PreferredID { get; set; }
        public string Note { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<CourseTaskVm> CourseTasks { get; set; }
        public virtual ICollection<DailyTaskVm> DailyTasks { get; set; }
        public virtual ICollection<HealthExaminationDetailVm> HealthExaminationDetails { get; set; }
        public virtual ICollection<HealthProblemVm> HealthProblems { get; set; }
        public virtual LocationVm Location { get; set; }
        public virtual PreferredVm Preferred { get; set; }
        public virtual ICollection<ReceivableDetail_StudentVm> ReceivableDetail_Student { get; set; }
        public virtual ICollection<Student_ClassVm> Student_Class { get; set; }
        public virtual ICollection<Student_LessonVm> Student_Lesson { get; set; }
        public virtual ICollection<StudentParentVm> StudentParents { get; set; }
    }
}