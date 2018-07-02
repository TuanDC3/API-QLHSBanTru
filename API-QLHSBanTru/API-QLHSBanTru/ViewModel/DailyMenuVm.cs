using System.Collections.Generic;

namespace API_QLHSBanTru.ViewModel
{
    public class DailyMenuVm
    {
        public int DailyMenuID { get; set; }
        public string Name { get; set; }
        public int WeeklyMenuID { get; set; }
        public System.DateTime Date { get; set; }
        public bool IsForm { get; set; }
        public bool Status { get; set; }

        public virtual WeeklyMenuVm WeeklyMenu { get; set; }
        public virtual ICollection<DailyMenuDetailVm> DailyMenuDetails { get; set; }
    }
}