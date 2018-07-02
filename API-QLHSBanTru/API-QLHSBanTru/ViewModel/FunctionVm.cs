using System.Collections.Generic;

namespace API_QLHSBanTru.ViewModel
{
    public class FunctionVm
    {
        public int FunctionID { get; set; }
        public int FunctionGroupID { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Employee_FunctionVm> Employee_Function { get; set; }
        public virtual FunctionGroupVm FunctionGroup { get; set; }

        public virtual ICollection<HistoryVm> Histories { get; set; }
    }
}