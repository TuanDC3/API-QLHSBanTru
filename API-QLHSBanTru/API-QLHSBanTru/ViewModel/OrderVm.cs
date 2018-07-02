using System.Collections.Generic;

namespace API_QLHSBanTru.ViewModel
{
    public class OrderVm
    {
        public int OrderID { get; set; }
        public string OrderName { get; set; }
        public System.DateTime Date { get; set; }
        public int EmployeeID1 { get; set; }
        public int EmployeeID2 { get; set; }
        public int EmployeeID3 { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<OrderDetailVm> OrderDetails { get; set; }
    }
}