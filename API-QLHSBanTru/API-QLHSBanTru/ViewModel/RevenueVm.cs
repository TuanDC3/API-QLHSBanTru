using System;
using System.Collections.Generic;

namespace API_QLHSBanTru.ViewModel
{
    public class RevenueVm
    {
        public int RevenueID { get; set; }
        public string RevenueName { get; set; }
        public Nullable<double> TotalRevenue { get; set; }
        public Nullable<bool> Status { get; set; }

        public virtual ICollection<ReceivableDetailVm> ReceivableDetails { get; set; }
    }
}