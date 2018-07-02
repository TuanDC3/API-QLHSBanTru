using System;
using System.Collections.Generic;

namespace API_QLHSBanTru.ViewModel
{
    public class LocationVm
    {
        public int LocationID { get; set; }
        public string LocationCode { get; set; }
        public string LocationName { get; set; }
        public string LocationNameEnglish { get; set; }
        public int LocationGrade { get; set; }
        public Nullable<int> LocationParent { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<EmployeeVm> Employees { get; set; }

        public virtual ICollection<StudentVm> Students { get; set; }
    }
}