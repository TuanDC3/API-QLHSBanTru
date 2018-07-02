using System;

namespace API_QLHSBanTru.ViewModel
{
    public class HistoryVm
    {
        public int HistoryID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<int> FunctionID { get; set; }
        public Nullable<System.DateTime> HistoryTime { get; set; }
        public string Detail { get; set; }
        public Nullable<bool> Status { get; set; }

        public virtual EmployeeVm Employee { get; set; }
        public virtual FunctionVm Function { get; set; }
    }
}