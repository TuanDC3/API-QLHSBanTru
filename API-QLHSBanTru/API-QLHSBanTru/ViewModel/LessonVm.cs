using System.Collections.Generic;

namespace API_QLHSBanTru.ViewModel
{
    public class LessonVm
    {
        public int LessonID { get; set; }
        public string Name { get; set; }
        public int TopicID { get; set; }
        public bool Status { get; set; }

        public virtual TopicVm Topic { get; set; }

        public virtual ICollection<Student_LessonVm> Student_Lesson { get; set; }
    }
}