using System.Collections.Generic;

namespace API_QLHSBanTru.ViewModel
{
    public class DepartmentVm
    {
        public int DepartmentID { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<ContractVm> Contracts { get; set; }
    }
}