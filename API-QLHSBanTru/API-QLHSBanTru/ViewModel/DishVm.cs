using System.Collections.Generic;

namespace API_QLHSBanTru.ViewModel
{
    public class DishVm
    {
        public int DishID { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<DailyMenuDetailVm> DailyMenuDetails { get; set; }
        public virtual ICollection<DishDetailVm> DishDetails { get; set; }
    }
}