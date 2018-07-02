using System.Collections.Generic;

namespace API_QLHSBanTru.ViewModel
{
    public class TopicTypeVm
    {
        public int TopicTypeID { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<TopicVm> Topics { get; set; }
    }
}