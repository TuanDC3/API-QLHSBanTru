namespace API_QLHSBanTru.ViewModel
{
    public class DailyMenuDetailVm
    {
        public int DailyMenuID { get; set; }
        public int MealID { get; set; }
        public int DishID { get; set; }
        public bool Status { get; set; }

        public virtual DailyMenuVm DailyMenu { get; set; }
        public virtual DishVm Dish { get; set; }
        public virtual MealVm Meal { get; set; }
    }
}