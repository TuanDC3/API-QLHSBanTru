using System.Collections.Generic;

namespace API_QLHSBanTru.ViewModel
{
    public class MealVm
    {
        public int MealID { get; set; }
        public string Name { get; set; }
        public System.TimeSpan Time { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<DailyMenuDetailVm> DailyMenuDetails { get; set; }
    }
}