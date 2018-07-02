namespace API_QLHSBanTru.ViewModel
{
    public class ReceivableDetail_PreferredVm
    {
        public int ReceivableDetailID { get; set; }
        public int PreferredID { get; set; }
        public double Percent { get; set; }
        public bool Status { get; set; }

        public virtual PreferredVm Preferred { get; set; }
        public virtual ReceivableDetailVm ReceivableDetail { get; set; }
    }
}