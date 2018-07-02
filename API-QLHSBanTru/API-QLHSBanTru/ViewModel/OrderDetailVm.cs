namespace API_QLHSBanTru.ViewModel
{
    public class OrderDetailVm
    {
        public int OrderID { get; set; }
        public int IngredientID { get; set; }
        public decimal PriceOfUnit { get; set; }
        public int QuantityOfUnit { get; set; }
        public decimal TotalPrice { get; set; }
        public byte Discount { get; set; }
        public bool Status { get; set; }

        public virtual IngredientVm Ingredient { get; set; }
        public virtual OrderVm Order { get; set; }
    }
}