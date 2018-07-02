using System.Collections.Generic;

namespace API_QLHSBanTru.ViewModel
{
    public class WeeklyMenuVm
    {
        public int WeeklyMenuID { get; set; }
        public string Name { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<DailyMenuVm> DailyMenus { get; set; }
    }
}