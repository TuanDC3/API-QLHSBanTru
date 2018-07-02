using System.Collections.Generic;

namespace API_QLHSBanTru.ViewModel
{
    public class PreferredVm
    {
        public int PreferredID { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<ReceivableDetail_PreferredVm> ReceivableDetail_Preferred { get; set; }
        public virtual ICollection<StudentVm> Students { get; set; }
    }
}