using System;
using System.Collections.Generic;

namespace API_QLHSBanTru.ViewModel
{
    public class ReceivableDetailVm
    {
        public int ReceivableDetailID { get; set; }
        public int ReceivableID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal SalePrice { get; set; }
        public bool Status { get; set; }
        public Nullable<int> RevenueID { get; set; }

        public virtual ReceivableVm Receivable { get; set; }
        public virtual ICollection<ReceivableDetail_PreferredVm> ReceivableDetail_Preferred { get; set; }
        public virtual RevenueVm Revenue { get; set; }
        public virtual ICollection<ReceivableDetail_StudentVm> ReceivableDetail_Student { get; set; }
    }
}