namespace API_QLHSBanTru.ViewModel
{
    public class Employee_ClassVm
    {
        public int EmployeeID { get; set; }
        public int ClassID { get; set; }
        public bool Status { get; set; }

        public virtual ClassVm Class { get; set; }
        public virtual EmployeeVm Employee { get; set; }
    }
}