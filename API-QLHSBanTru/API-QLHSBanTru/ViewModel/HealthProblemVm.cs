using System;

namespace API_QLHSBanTru.ViewModel
{
    public class HealthProblemVm
    {
        public int HealthProblemID { get; set; }
        public int StudentID { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string Signal { get; set; }
        public string Diagnosed { get; set; }
        public string Measure { get; set; }
        public int Serverity { get; set; }
        public int EmployeeID { get; set; }
        public Nullable<bool> Status { get; set; }

        public virtual EmployeeVm Employee { get; set; }
        public virtual StudentVm Student { get; set; }
    }
}