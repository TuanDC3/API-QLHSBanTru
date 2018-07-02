using System.Collections.Generic;

namespace API_QLHSBanTru.ViewModel
{
    public class TopicVm
    {
        public int TopicID { get; set; }
        public string Name { get; set; }
        public int TopicTypeID { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<LessonVm> Lessons { get; set; }
        public virtual TopicTypeVm TopicType { get; set; }
    }
}