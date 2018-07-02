namespace API_QLHSBanTru.ViewModel
{
    public class DishDetailVm
    {
        public int DishDetailID { get; set; }
        public int DishID { get; set; }
        public int IngredientID { get; set; }
        public double QuantiyOfUnit { get; set; }
        public bool Status { get; set; }

        public virtual DishVm Dish { get; set; }
        public virtual IngredientVm Ingredient { get; set; }
    }
}