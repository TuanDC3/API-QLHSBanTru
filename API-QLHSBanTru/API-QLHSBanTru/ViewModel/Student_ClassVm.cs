namespace API_QLHSBanTru.ViewModel
{
    public class Student_ClassVm
    {
        public int StudentID { get; set; }
        public int ClassID { get; set; }
        public string Note { get; set; }
        public bool Status { get; set; }

        public virtual ClassVm Class { get; set; }
        public virtual StudentVm Student { get; set; }
    }
}