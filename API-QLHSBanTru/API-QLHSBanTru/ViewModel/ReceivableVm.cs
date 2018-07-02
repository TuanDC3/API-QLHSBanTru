using System;
using System.Collections.Generic;

namespace API_QLHSBanTru.ViewModel
{
    public class ReceivableVm
    {
        public int ReceivableID { get; set; }
        public string Name { get; set; }
        public decimal TotalPrice { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public bool Status { get; set; }
        public Nullable<int> RevenueID { get; set; }

        public virtual ICollection<ReceivableDetailVm> ReceivableDetails { get; set; }
    }
}