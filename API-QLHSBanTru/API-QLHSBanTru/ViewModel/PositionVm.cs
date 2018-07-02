using System.Collections.Generic;

namespace API_QLHSBanTru.ViewModel
{
    public class PositionVm
    {
        public int PositionID { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<ContractVm> Contracts { get; set; }
    }
}