namespace API_QLHSBanTru.ViewModel
{
    public class ContractVm
    {
        public int ContractID { get; set; }
        public string ContractType { get; set; }
        public int EmployeeID { get; set; }
        public int DepartmentID { get; set; }
        public int PositionID { get; set; }
        public double PayRate { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime CreateDate { get; set; }
        public bool Status { get; set; }

        public virtual DepartmentVm Department { get; set; }
        public virtual EmployeeVm Employee { get; set; }
        public virtual PositionVm Position { get; set; }
    }
}