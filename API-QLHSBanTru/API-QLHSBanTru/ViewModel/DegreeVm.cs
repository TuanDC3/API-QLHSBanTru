using System.Collections.Generic;

namespace API_QLHSBanTru.ViewModel
{
    public class DegreeVm
    {
        public int DegreeID { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<EmployeeVm> Employees { get; set; }
    }
}