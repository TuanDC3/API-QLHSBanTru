namespace API_QLHSBanTru.ViewModel
{
    public class ReceivableDetail_StudentVm
    {
        public int ReceivableDetailID { get; set; }
        public int StudentID { get; set; }
        public bool Status { get; set; }

        public virtual ReceivableDetailVm ReceivableDetail { get; set; }
        public virtual StudentVm Student { get; set; }
    }
}