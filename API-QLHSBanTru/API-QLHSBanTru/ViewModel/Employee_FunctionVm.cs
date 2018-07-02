namespace API_QLHSBanTru.ViewModel
{
    public class Employee_FunctionVm
    {
        public int EmployeeID { get; set; }
        public int FunctionID { get; set; }
        public bool Status { get; set; }

        public virtual EmployeeVm Employee { get; set; }
        public virtual FunctionVm Function { get; set; }
    }
}