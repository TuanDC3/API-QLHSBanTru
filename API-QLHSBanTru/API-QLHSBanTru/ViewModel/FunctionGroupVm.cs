using System;
using System.Collections.Generic;

namespace API_QLHSBanTru.ViewModel
{
    public class FunctionGroupVm
    {
        public int FunctionGroupID { get; set; }
        public string Name { get; set; }
        public Nullable<bool> Status { get; set; }

        public virtual ICollection<FunctionVm> Functions { get; set; }
    }
}