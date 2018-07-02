using System;
using System.Collections.Generic;

namespace API_QLHSBanTru.ViewModel
{
    public class EmployeeVm
    {
        public int EmployeeID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public Nullable<bool> Gender { get; set; }
        public int EthnicGroupID { get; set; }
        public int ReligionID { get; set; }
        public byte[] Image { get; set; }
        public int LocationID { get; set; }
        public string AddressDetail { get; set; }
        public Nullable<int> DegreeID { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string IdentityNumber { get; set; }
        public System.DateTime DateOfIssue { get; set; }
        public string PlaceOfIssue { get; set; }
        public string Note { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<ContractVm> Contracts { get; set; }
        public virtual DegreeVm Degree { get; set; }
        public virtual ICollection<Employee_ClassVm> Employee_Class { get; set; }
        public virtual EthnicGroupVm EthnicGroup { get; set; }
        public virtual ICollection<Employee_FunctionVm> Employee_Function { get; set; }
        public virtual LocationVm Location { get; set; }
        public virtual ReligionVm Religion { get; set; }
        public virtual ICollection<HealthProblemVm> HealthProblems { get; set; }
        public virtual ICollection<HistoryVm> Histories { get; set; }
    }
}